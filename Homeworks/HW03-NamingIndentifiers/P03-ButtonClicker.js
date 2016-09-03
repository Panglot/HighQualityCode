function buttonClicker(event, arguments) {
    var browser = window.navigator.appCodeName,
        theBrowserIsMozilla = (browser == "Mozilla");

    if (theBrowserIsMozilla) {
        alert("Your browser is Mozilla Firefox");
    }
    else {
        alert("Your browser is NOT Mozilla Firefox");
    }
}
