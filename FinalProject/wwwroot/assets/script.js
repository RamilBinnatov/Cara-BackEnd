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

let input = document.getElementsByClassName(".search-area")
let searchList = document.getElementById("searchList")
let button = document.getElementById("search-button")



//button.addEventListener('click', () => {
//    if (searchList.classList.contains('searchBlock')) {
//        searchList.classList.remove('searchBlock')
//    }
//    else {
//        searchList.classList.add('searchBlock')
//    }
//})


$(document).on("click", ".salam12321", function () {

	let productId = parseInt($($(this).closest(".godzilla")[0]).attr('id'));

	let data = { id: productId };
    
	$.ajax({
		url: "/home/addbasket",
		type: "POST",
		data: data,
		contentType: "application/x-www-form-urlencoded",
		success: function (res) {
			swal({
				type: 'success',
				title: 'Product added',
				showConfirmButton: false,
				timer: 1000
			});
		}
	})

});

$(function () {

	$(document).on("keyup", "#searchinp", function () {
		let inputVal = $(this).val().trim();
		$(".search-list-p li").slice(0).remove();
		$.ajax({
			method: "get",
			url: "home/search?search=" + inputVal,
			success: function (res) {
				$(".search-list-p").append(res);
			}
		});
	});
});


