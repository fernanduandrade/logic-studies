export default compararArray(array1, array2) {
    if (array1 === array2) {
	return true;
    }
    else if (array1 == null || array2 == null) {
	return false;
    }
    else if (array1.length !== array2.length) {
	return false;
    }

    for (var i = 0; i < array1.length; ++i) {
	if (array1[i] !== array2[i]) {
	    return false;
	}
    }
    return true;
};
