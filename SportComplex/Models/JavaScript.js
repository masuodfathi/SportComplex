document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById('contact-form');
    form.addEventListener('submit', function (e) {
        e.preventDefault();

        const name = document.getElementById('name').value;
        const email = document.getElementById('email').value;
        const message = document.getElementById('message').value;

        alert(`نام: ${name}\nایمیل: ${email}\nپیام: ${message}\nپیام شما با موفقیت ارسال شد!`);
    });




    // Dashboard Toggle
    const toggleButton = document.querySelector('.dashboard-toggle');
    const dashboardContent = document.querySelector('.dashboard-content');

    toggleButton.addEventListener('click', function () {
        if (dashboardContent.style.display === 'block') {
            dashboardContent.style.display = 'none';
        } else {
            dashboardContent.style.display = 'block';
        }
    });
});






document.getElementById('navbar-toggle').addEventListener('click', function () {
    const navbarMenu = document.getElementById('navbar-menu');
    navbarMenu.classList.toggle('active');
});





var modal = document.getElementById('id01');

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}