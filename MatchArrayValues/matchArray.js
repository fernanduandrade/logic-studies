const matchValores = (array1, array2) => {
    let novaArray = [];
    for (let i = 0; i < array2.length; i++) {
	for (let z = 0; z < array1.length; z++) {
	    if (array1[z] ===array2[i]) {
		novaArray.push(array2[i]);
	    }
	}
    }

    return novaArray;
}


module.exports = matchValores;
