export default arrayParaObject(array)  {
    let meuObjeto = {};
    array.forEach(elemento => {

	const [objecto, valor] = elemento;
	if(!meuObjeto[objecto]) {
	    meuObjeto[objecto] = valor;
	}
    });

    return meuObjeto;
}
