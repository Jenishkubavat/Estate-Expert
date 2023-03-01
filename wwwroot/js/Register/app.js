const sign_in_btn = document.querySelector("#sign-in-btn");
const sign_up_btn = document.querySelector("#sign-up-btn");
const container = document.querySelector(".container");
var password = document.getElementById("txtPassword").value;
var confirmPassword = document.getElementById("txtConfirmPassword").value;
sign_up_btn.addEventListener("click", () => {
  container.classList.add("sign-up-mode");
});

sign_in_btn.addEventListener("click", () => {
  container.classList.remove("sign-up-mode");
});
function Validate() {
 
    if (password != confirmPassword) {
        alert("Passwords do not match.");
        return false;
    }
    return true;
}