export default removerItens(array, ...valores) {
    return array.filter(elemento => !valores.includes(elemento));
}
