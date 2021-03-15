const removerItens = (array, ...valores)  => array.filter(elemento => !valores.includes(elemento));

module.exports = removerItens;
