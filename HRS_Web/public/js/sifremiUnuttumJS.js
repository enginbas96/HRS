function rakamKontrol(event) {
    var inputElement = event.target;
    var inputValue = inputElement.value;
    var filteredValue = '';

    // Sadece rakamların girilmesine izin ver
    for (var i = 0; i < inputValue.length; i++) {
        var charStr = inputValue.charAt(i);
        if (charStr.match(/^[0-9]+$/)) {
            filteredValue += charStr;
        }
    }
    inputElement.value = filteredValue;
}
function kontrolEt() {
    var tcInput = document.getElementById('tc');
    var tcValue = tcInput.value.trim();

    var mailInput = document.getElementById('email');
    var mailValue = mailInput.value;

    if (tcValue.length !== 11) {
        alert('TC Kimlik numarasını eksiksiz olarak giriniz.');
        return false;
    }
    if (mailValue.length < 5) {
        alert('Mail adresinizin doğru olduğundan emin olunuz.');
        return false;
    }
    return true;
}
