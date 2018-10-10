function getReceipt() {
	text1 = ""; 
	text2 = ""; 
	var runningTotal = 0;
	var sizeTotal = 0;
	var sizeArray = document.getElementsByClassName("size");
	for (var i = 0; i < sizeArray.length; i++) {
		if (sizeArray[i].checked) {
			var selectedSize = sizeArray[i].value;
			text1 = text1+selectedSize+"<br>";
		}
	}
	if (selectedSize === "Personal Pizza") {
		sizeTotal = 6;
		text2 = text2+sizeTotal+"<br>";
	} else if (selectedSize === "Medium Pizza") {
		sizeTotal = 10;
		text2 = text2+sizeTotal+"<br>";
	} else if (selectedSize === "Large Pizza") {
		sizeTotal = 14;
		text2 = text2+sizeTotal+"<br>";
	} else if (selectedSize === "Extra Large Pizza") {
		sizeTotal = 16;
		text2 = text2+sizeTotal+"<br>";
	}
	runningTotal = sizeTotal;
	getMeat(runningTotal,text1,text2); 
};	

function getMeat(runningTotal,text1,text2) {
	var runningTotal = runningTotal;
	var meatTotal = 0;
	var selectedMeat = [];
	var meatArray = document.getElementsByClassName("meats");
	for (var j = 0; j < meatArray.length; j++) {
		if (meatArray[j].checked) {
			selectedMeat.push(meatArray[j].value);
		}
	}
	var meatCount = selectedMeat.length;
	if (meatCount > 1) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
	}
	runningTotal = (runningTotal + meatTotal);
	for (var j = 0; j < selectedMeat.length; j++) {
			text1 = text1+selectedMeat[j]+"<br>";
			if (meatCount <= 1) {
				text2 = text2 + 0 + "<br>";
				meatCount = meatCount - 1;
			} else if (meatCount == 2) {
				text2 = text2 + 1 + "<br>";
				meatCount = meatCount - 1;
			} else {
				text2 = text2 + 1 + "<br>";
				meatCount = meatCount - 1;
			}
	}
	getVeggie(runningTotal,text1,text2);
};

function getVeggie(runningTotal,text1,text2) {
	var veggieTotal = 0;
	var selectedVeggie = [];
	var veggieArray = document.getElementsByClassName("veggies");
	for (var j = 0; j < veggieArray.length; j++) {
		if (veggieArray[j].checked) {
			selectedVeggie.push(veggieArray[j].value);
		}
	}
	var veggieCount = selectedVeggie.length;
	if (veggieCount > 1) {
		veggieTotal = (veggieCount - 1);
	} else {
		veggieTotal = 0;
	}
	runningTotal = (runningTotal + veggieTotal);
	for (var j = 0; j < selectedVeggie.length; j++) {
			text1 = text1+selectedVeggie[j]+"<br>";
			if (veggieCount <= 1) {
				text2 = text2 + 0 + "<br>";
				veggieCount = veggieCount - 1;
			} else if (veggieCount == 2) {
				text2 = text2 + 1 + "<br>";
				veggieCount = veggieCount - 1;
			} else {
				text2 = text2 + 1 + "<br>";
				veggieCount = veggieCount - 1;
			}
	}
	getCheese(runningTotal,text1,text2);
};

function getCheese(runningTotal,text1,text2) {
	var cheeseTotal = 0;
	var selectedCheese = [];
	var cheeseArray = document.getElementsByClassName("cheese");
	for (var j = 0; j < cheeseArray.length; j++) {
		if (cheeseArray[j].checked) {
			selectedCheese = cheeseArray[j].value;
		}
		if (selectedCheese === "Extra cheese") {
			cheeseTotal = 3;
		}
	}
	text1 = text1+selectedCheese+"<br>";
	text2 = text2+cheeseTotal+"<br>";
	runningTotal = (runningTotal + cheeseTotal);
	getSauce(runningTotal,text1,text2);
};

function getSauce(runningTotal,text1,text2) {
	var sauceTotal = 0;
	var selectedSauce = [];
	var sauceArray = document.getElementsByClassName("sauce");
	for (var j = 0; j < sauceArray.length; j++) {
		if (sauceArray[j].checked) {
			selectedSauce = sauceArray[j].value;
			text1 = text1 + selectedSauce +"<br>";
		}
	}
	text2 = text2 + 0 + "<br>";
	getCrust(runningTotal,text1,text2)
};

function getCrust(runningTotal,text1,text2) {
	var crustTotal = 0;
	var selectedCrust = [];
	var crustArray = document.getElementsByClassName("crust");
	for (var j = 0; j < crustArray.length; j++) {
		if (crustArray[j].checked) {
			selectedCrust = crustArray[j].value;
		}
		if (selectedCrust === "Cheese Stuffed Crust") {
			crustTotal = 3;
		}
	}
	text1 = text1 + selectedCrust + "<br>";
	text2 = text2 + crustTotal + "<br>";
	runningTotal = (runningTotal + crustTotal);
	giveTip(runningTotal,text1,text2);
};

function giveTip(runningTotal,text1,text2) {
	var tipTotal = 0;
	var selectedTip = [];
	var tipArray = document.getElementsByClassName("tip");
	for (var j = 0; j <tipArray.length; j++) {
		if (tipArray[j].checked) {
			selectedTip = tipArray[j].value;
		}
		if (selectedTip === "$1") {
			tipTotal = 1;
		}
		if (selectedTip === "$2") {
			tipTotal = 2;
		}
		if (selectedTip === "$3") {
			tipTotal = 3;
		}
		if (selectedTip === "$4") {
			tipTotal = 4;
		}
		if (selectedTip === "$5") {
			tipTotal = 5;
		}
	}
	text1 = text1 + selectedTip + "<br>";
	text2 = text2 + tipTotal + "<br>";
	runningTotal = (runningTotal + tipTotal);
	
	document.getElementById("showText1").innerHTML=text1;
	document.getElementById("showText2").innerHTML=text2;
	document.getElementById("totalPrice2").innerHTML = "</h3>$"+runningTotal+".00"+"</h3>";
};
