import { data } from './data';
import { Gallery } from './Gallery';

const galleryElement = document.getElementsByClassName('gallery')[0];
const gallery = new Gallery(galleryElement, data);