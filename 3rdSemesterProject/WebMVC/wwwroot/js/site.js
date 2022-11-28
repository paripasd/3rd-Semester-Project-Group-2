function validateBuyForm() {
    var emailInput = document.getElementById("emailfield");
    if (emailInput.value == "") {
        alert("Input an email address!");
        return false;
    } /*if the field isn't empty the html imput type email verifies that it's an email address*/

    var paymentMethodInput = document.getElementById("paymentmethod");
    if (paymentMethodInput.value == "none") {
        alert("Select payment method!");
        return false;
    }

    var tosInput = document.getElementById("toscheckbox");
    if (tosInput.checked == false) {
        alert("You have to accept the terms of service to purchase");
        return false;
    }
    return true;
}

function DownloadGame() {
    window.open("localhost:7064/Game/DownloadGame?gameId=" + );
}