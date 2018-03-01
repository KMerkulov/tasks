import { Modal } from './Modal';
import { Image } from './Image';

export class Gallery {
	constructor (element, images){
		this.images = [];
		this.galleryListElement = element.getElementsByClassName('gallery-list')[0];
		this.buttonWrapper = element.getElementsByClassName('add-img')[0];
		this.addImageToGallery = element.getElementsByClassName('add-img-bnt')[0];

		const modalElement = element.getElementsByClassName('modal')[0];

		this.modal = new Modal(modalElement);

		images.forEach(image => {
			this.add(image);
		});

		this.addImageToGallery.addEventListener('change', () => {
			this.onInputChange();
		});
	}
	add(image) {
		const img = new Image(image);
		const imageElement = img.render();

		this.images.push(img);
		this.galleryListElement.insertBefore(imageElement, this.buttonWrapper);

		imageElement.addEventListener('click', () => {
			this.modal.open(img);
		});
	}
	onInputChange() {
		const file = this.addImageToGallery.files[0];

		if(!file) {
			return;
		}
		this.readAsDataURL(file) 
			.then(this.loadImage)
			.then(img => {
				this.add(img);
			})
			.catch(img => {
				alert(error.message);
			});
	}
	readAsDataURL(file) {
		return new Promise((resolve, reject) => {
			const reader = new FileReader();

			reader.onloadend = function() {
				resolve(reader.result)
			};

			reader.readAsDataURL(file);
		});
	}
	loadImage(readerResult){
		return new Promise((resolve, reject) => {
			const img = new window.Image();

			img.onload = function() {
				resolve({
					url: readerResult,
					type: imageGetType(this.width, this.height)
				});

			};

			img.onerror = function() {
				reject(new Error ('Ошибка загрузки изображения!'));
			};

			img.src = readerResult;
		});
	}
}

function imageGetType(width, height) {
	const res = width / height;

	if(res > 1.6)
		return 'wide';
	if(res < 0.8)
		return 'high';

	return 'square';
}