const reverterArray = array => {
    let Valortemporario;
    for(let i = 0; i < array.length / 2; i++) {
	Valortemporario = array[i]
	array[i] = array[array.length -1 -i]
	array[array.length - 1 -i] = Valortemporario
    }

    return array; 
}

module.exports = reverterArray;
