////navbar = document.querySelector('.main_nav_contaner').querySelectorAll('a');
////console.log(navbar);

////navbar.forEach(element => {
////    element.addEventListener("click", function () {
////        navbar.forEach(nav => nav.classlist.remove("active"))
////        this.classlist.add("active");
////    })

////});
var a = document.querySelectorAll(".main_nav a");
console.log(a);
for (var i = 0, length = a.length; i < length; i++) {
    a[i].onclick = function () {
        console.log(a);
        var b = document.querySelector(".main_nav li.active");
        if (b) b.classList.remove("active");
        this.parentNode.classList.add('active');
    };
}
