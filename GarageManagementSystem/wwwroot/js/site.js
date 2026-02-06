// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const toggleBtn = document.getElementById("themeToggle");
    const body = document.body;

    // Load saved preference
    const savedTheme = localStorage.getItem("theme");
    if (savedTheme === "dark") {
        body.classList.add("dark-mode");
        toggleBtn.textContent = "☀️";
    }

    toggleBtn?.addEventListener("click", function () {
        body.classList.toggle("dark-mode");

        const isDark = body.classList.contains("dark-mode");
        localStorage.setItem("theme", isDark ? "dark" : "light");

        toggleBtn.textContent = isDark ? "☀️" : "🌙";
    });
});