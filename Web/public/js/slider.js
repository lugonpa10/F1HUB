document.addEventListener('DOMContentLoaded', () => {
    const leftPanel = document.getElementById('slider-left');
    const rightPanel = document.getElementById('slider-right');


   const images = [
        'http://localhost:8000/imagenes/ferrari.jpg',
        'http://localhost:8000/imagenes/alonsoPodio.jpg',
        'http://localhost:8000/imagenes/max.jpg',
        'http://localhost:8000/imagenes/senna.jpg',


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