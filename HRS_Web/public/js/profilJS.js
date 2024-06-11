function kontrolEt() {
    var password = document.getElementById('password');
    var passwordR = document.getElementById('passwordR');
    if (password.value.length < 8) {
        alert('Yeni şifreniz 8 karakterden büyük olmalıdır.');
        return false;
    } else if (password.value !== passwordR.value) {
        alert('Girilen yeni şifreler birbiriyle eşleşmiyor.');
        return false;
    }
    return true;
}
