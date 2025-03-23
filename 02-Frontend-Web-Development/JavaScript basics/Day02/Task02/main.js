function palindromeChecker(text, caseSensitivity) {
  if (caseSensitivity) {
    return text == text.split("").reverse().join("");
  } else {
    return (
      text.toLowerCase() == text.split("").reverse().join("").toLowerCase()
    );
  }
}
var userInput = prompt("Enter text to check palindrome");
var isPalindrome;
if (confirm("Preserve case sensitivity?")) {
  isPalindrome = palindromeChecker(userInput, true);
} else {
  isPalindrome = palindromeChecker(userInput, false);
}

if (isPalindrome) {
  document.writeln("<h1>" + userInput + " is a palindrome</h1>");
} else {
  document.writeln("<h1>" + userInput + " is not a palindrome</h1>");
}
