class Modal {
  constructor(options) {
    this.modal = document.createElement("div");
    this.modal.className = "modal";
    this.modal.innerHTML = `
            <div class="modal-content">
                <div class="modal-header">
                ${
                  options.type == "warning"
                    ? `<i class="fa-solid fa-triangle-exclamation" style="color: #ffd43b;"></i>`
                    : `<i class="fa-solid fa-circle-check" style="color: #4bb543;"></i>`
                }
                    <h2>${options.title}</h2>
                    <button class="close-btn" id="modalCloseBtn"><i class="fa-solid fa-xmark" style="padding: 5px; color: #a30000;"></i></button>
                </div>
                <div class="modal-body">
                    <p>${options.message}</p>
                </div>
            </div>
        `;

    // Add to DOM
    document.body.appendChild(this.modal);

    // Get close button reference - wait for DOM to be ready
    setTimeout(() => {
      this.closeBtn = this.modal.querySelector("#modalCloseBtn");
      this.setupEvents();
    }, 0);
  }

  setupEvents() {

    this.closeBtn.addEventListener("click", () => this.close());

    this.modal.addEventListener("click", (e) => {
      if (e.target === this.modal) {
        this.close();
      }
    });
   
    document.addEventListener("keydown", (e) => {
      if (e.key === "Escape" && this.modal.style.display === "flex") {
        this.close();
      }
    });
  }

  open() {
    this.modal.style.display = "flex";
  }

  close() {
    this.modal.style.display = "none";
  }

 
  updateContent({ title, message }) {
    if (title) {
      this.modal.querySelector(".modal-header h2").textContent = title;
    }
    if (message) {
      this.modal.querySelector(".modal-body p").textContent = message;
    }
  }

  destroy() {
    this.modal.remove();
  }
}

export default Modal;
