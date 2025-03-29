document.addEventListener("keydown", function (event) {
  var key = event.key;
  var asciiCode =
    key.length === 1
      ? key.charCodeAt(0)
      : "NOt an ASCII character, May be a special key in Extended ASCII only";
  var commandKeys = [];

  if (event.altKey) commandKeys.push("Alt");
  if (event.ctrlKey) commandKeys.push("Ctrl");
  if (event.shiftKey) commandKeys.push("Shift");

  var message = "ASCII Code: " + asciiCode;
  if (commandKeys.length > 0) {
    message += " | " + commandKeys.join(", ");
  }

  document.getElementById("info").innerText = message;
});

document.addEventListener("contextmenu", function (event) {
  event.preventDefault();
  document.getElementById("info2").innerText =
    "Right-click context menu is disabled";
});
