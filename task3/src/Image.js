import { Comment } from './Comment';

export class Image{
	constructor (image) {
		this.url = image.url;
		this.type = image.type;
		this.likes = image.likes || 0;
		this.dislikes = image.dislikes || 0;
		this.isLiked = image.isLiked || false;
		this.isDisliked = image.isDisliked || false;
		this.comments = (image.comments || [])
			.map(comment => new Comment(comment.nickname, comment.timestamp, comment.comment));
	}
	render() {
		this.imgElement = document.createElement('div');
		this.imgElement.classList.add('image');
		this.checkTypeImage();
		this.imgElement.style.backgroundImage = `url('${this.url}')`;
		this.imgElement.innerHTML = `
		<footer class='image-footer'>
			<div class="comment-footer"><div class="num-comment">${this.comments.length}</div></div>
			<div class="dislike-footer"><div class="num-dislikes">${this.dislikes}</div></div>
			<div class="like-footer"><div class="num-likes">${this.likes}</div></div>
		</footer>`;

		this.likeEl = this.imgElement.getElementsByClassName('num-likes')[0];
		this.dislikeEl = this.imgElement.getElementsByClassName('num-dislikes')[0];
		this.commentEl = this.imgElement.getElementsByClassName('num-comment')[0];

		return this.imgElement;
	}
	checkTypeImage() {
		if(this.type == 'wide'){
			this.imgElement.classList.add('wide');
		}else if(this.type == 'high'){
			this.imgElement.classList.add('high');
		}
	}
	like() {
		if(this.isLiked){
			this.isLiked = false;
			this.likes--;
		}else{
			this.isLiked = true;
			this.likes++;
		}
		if(this.isDisliked){
			this.isDisliked = false;
			this.dislikes--;
		}

		this.likeEl.innerHTML = this.likes;
		this.dislikeEl.innerHTML = this.dislikes;
	}
	dislike() {
		if(this.isDisliked){
			this.isDisliked = false;
			this.dislikes--;
		}else{
			this.isDisliked = true;
			this.dislikes++;
		}
		if(this.isLiked){
			this.isLiked = false;
			this.likes--;
		}

		this.likeEl.innerHTML = this.likes;
		this.dislikeEl.innerHTML = this.dislikes;
	}
	addComment(comment) {
		this.comments.push(comment);
		this.commentEl.innerHTML = this.comments.length;
	}
}