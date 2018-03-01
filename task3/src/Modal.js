import { Image } from './Image';
import { Comment } from './Comment';

export class Modal {
	constructor (elem) {
		this.element = elem;
		this.image = elem.getElementsByClassName("img")[0];
		this.likeButton = elem.getElementsByClassName("like")[0];
		this.dislikeButton = elem.getElementsByClassName("dislike")[0];
		this.commentsLength = elem.getElementsByClassName('comments-length')[0];
		this.commentsContainer = elem.getElementsByClassName('comments-container')[0]; 
		this.likesNumbers = elem.getElementsByClassName('number-likes')[0];
		this.dislikesNumbers = elem.getElementsByClassName('number-dislikes')[0];

		const nickname = elem.getElementsByClassName('nickname')[0];
		const modalContainer = elem.getElementsByClassName('container')[0];
		const close = elem.getElementsByClassName('close')[0];
		const message = elem.getElementsByClassName('message')[0];
		const sendCommentButton = elem.getElementsByClassName('send-comment-button')[0];
		
		elem.addEventListener('click', () => {
			this.close();
		});
		modalContainer.addEventListener('click', event => {
			event.stopPropagation();
		});
		close.addEventListener('click', () => {
			this.close();
		});

		this.likeButton.addEventListener('click', () => {
			this.img.like();
			this.updateValues();
		});

		this.dislikeButton.addEventListener('click', () => {
			this.img.dislike();
			this.updateValues();
		});
		
		sendCommentButton.addEventListener('click', event => {
			const name = nickname.value;
			const text = message.value;
			const time = Date.now();

			const comment = new Comment(name, time, text);

			this.addCommentToDom(comment);
			this.img.addComment(comment);
			this.commentsLength.innerHTML = this.img.comments.length;

			nickname.value = '';
			message.value = '';
			
			event.preventDefault();
		});
	}
	open(img) {
		this.img = img;

		this.element.classList.add('active');
		this.image.style.backgroundImage = `url('${img.url}')`;
		this.updateValues();
		img.comments.forEach(comment => {
			this.addCommentToDom(comment);
		});
	}
	addCommentToDom(comment) {
		this.commentsContainer.prepend(comment.render());
	}
	close() {
		this.commentsContainer.innerHTML = '';
		this.element.classList.remove('active');
	}
	updateValues() {
		this.likesNumbers.innerHTML = this.img.likes;
		this.dislikesNumbers.innerHTML = this.img.dislikes;
		this.commentsLength.innerHTML = this.img.comments.length;
		
		this.likeButton.classList.toggle('active', this.img.isLiked);
		this.dislikeButton.classList.toggle('active', this.img.isDisliked);
	}
}