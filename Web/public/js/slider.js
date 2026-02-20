document.addEventListener('DOMContentLoaded', () => {
    const leftPanel = document.getElementById('slider-left');
    const rightPanel = document.getElementById('slider-right');


    const images = [
        'public/imagenes/alonsoPodio.jpg',
        'public/imagenes/max.jpg',
        'public/imagenes/senna.jpg',       
        'public/imagenes/michael.jpeg',
        'public/imagenes/mclarenCoche.jpeg',
        'public/imagenes/merc.jpg',
        'public/imagenes/niki-lauda.jpg',
        'public/imagenes/mclaren-1988.jpg'
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