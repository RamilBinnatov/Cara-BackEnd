const bar = document.getElementById('bar')
const nav = document.getElementById('navbar')
const closeBar = document.getElementById('close')
const navs = document.querySelectorAll('.nav');
const url = window.location.href;

if (bar){
    bar.addEventListener('click', () =>{
        nav.classList.add('active')
    })
}

closeBar.addEventListener('click', () =>{
    nav.classList.remove('active')
})

navs.forEach(nav => {
    if (url.substring(24, url.length) === nav.textContent) {
        nav.classList.add('active')
    }
    else {
        if (url.substring(24, url.length)=== 0) {
            nav.classList.add('active')
        }
        else {
            nav.classList.remove('active')
        }
    }
    
})

