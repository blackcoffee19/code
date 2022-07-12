// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const addToList = (name, price) => {
    const listCart = document.getElementById("list");
    const createEl1 = document.createElement("li");
    const createEl2 = document.createElement("span");
    const createText = document.createTextNode(name+" : ");
    const createPrice = document.createTextNode("$"+price);
    createEl2.appendChild(createPrice);
    createEl1.appendChild(createText);
    createEl1.appendChild(createEl2);
    listCart.appendChild(createEl1);
};
