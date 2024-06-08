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

    var passwordInput = document.getElementById('password');
    var passwordValue = passwordInput.value;

    if (tcValue.length !== 11) {
        alert('TC Kimlik numarasını eksiksiz olarak giriniz.');
        return false;
    }
    if (passwordValue.length < 8) {
        alert('Şifreniz en az 8 karakter olmalıdır!');
        return false;
    }
    return true;
}
