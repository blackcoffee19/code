const addToCart =(food)=>{
    const item = document.getElementById(food);
    let create = document.getElementById("cart");
    let addItem = document.createElement("h3");
    addItem.innerHTML = item.value;
    create.appendChild(addItem);
};
