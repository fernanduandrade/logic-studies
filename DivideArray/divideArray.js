const dividirArray = (array, divisor) => {
    let novaArray = array.reduce((acumulador, atualValor, i) => {
	if(!(i %  divisor)) {
	    acumulador.push(array.slice(i, i + divisor));
	}
	return acumulador
    }, []);

    return novaArray
}

module.exports = dividirArray;
