document.addEventListener('DOMContentLoaded', () => {
    const leftPanel = document.getElementById('slider-left');
    const rightPanel = document.getElementById('slider-right');


    const images = [
        '../public/imagenes/ferrari.jpg',
        '../public/imagenes/alonsoPodio.jpg',
        '../public/imagenes/max.jpg',
        '../public/imagenes/senna.jpg'

    ];

    let currentIndex = 0;

    function changeImages() {

        const leftIndex = currentIndex % images.length;
        const rightIndex = (currentIndex + 2) % images.length;

        leftPanel.style.backgroundImage = `url('${images[leftIndex]}')`;
        rightPanel.style.backgroundImage = `url('${images[rightIndex]}')`;

        currentIndex++;
    }


    changeImages();


    setInterval(changeImages, 4000);
});