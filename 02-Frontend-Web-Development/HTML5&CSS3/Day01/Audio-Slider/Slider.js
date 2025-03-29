// Audio elements
var audio = document.getElementById("audioPlayer");
var volumeInp = document.getElementById("volumeInp");
var timeInp = document.getElementById("timeInp");
var speed = document.getElementById("speed");
var trackInfo = document.getElementById("trackInfo");

// Track list
var tracks = [
    { name: "Birds", file: "audios/birds.mp3" },
    { name: "القناص - سبيستون", file: "audios/qannas.mp3" },
    { name: "سبيل الدموع", file: "audios/sabil-eldmo3.mp3" }
];
var currentTrack = 0;

function playAud() {
    audio.play();
}

function pauseAud() {
    audio.pause();
}

function stopAud() {
    audio.pause();
    audio.currentTime = 0;
}

function muteAud() {
    audio.muted = !audio.muted;
}

function prevTrack() {
    currentTrack--;
    if (currentTrack < 0) {
        currentTrack = tracks.length - 1;
    }
    setTrack(currentTrack);
}

function nextTrack() {
    currentTrack++;
    if (currentTrack >= tracks.length) {
        currentTrack = 0;
    }
    setTrack(currentTrack);
}

function setTrack(trackIndex) {
    var track = tracks[trackIndex];
    audio.src = track.file;
    trackInfo.textContent = "Now Playing: " + track.name;
    audio.load();
    audio.play();
}

volumeInp.addEventListener("input", function () {
    audio.volume = volumeInp.value;
});

audio.addEventListener("loadedmetadata", function() {
    timeInp.max = Math.floor(audio.duration);
});

timeInp.addEventListener("input", function () {
    audio.currentTime = timeInp.value;
});

audio.addEventListener("timeupdate", function () {
    timeInp.value = Math.floor(audio.currentTime);
});

speed.addEventListener("change", function () {
    audio.playbackRate = speed.value;
});

audio.addEventListener("ended", nextTrack);


window.onload = function() {
    setTrack(0);
};