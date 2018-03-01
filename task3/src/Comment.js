import moment from 'moment';

export class Comment {
	constructor (nickname, timestamp, comment) {
		this.nickname = nickname;
		this.timestamp = timestamp;
		this.comment = comment;
	}
	render() {
		const commElement = document.createElement('div');

		commElement.classList.add('comment');
		commElement.innerHTML = `
		<header class = "flexbox">
			<div class="name">By ${this.nickname}</div>
			<div class="time">${moment(this.timestamp).calendar()}</div>
		</header>
		<div class="text">${this.comment}</div>
		`;

		return commElement;
	}
}