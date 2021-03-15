const serializarArray = require('./serializeArray');

test('Unificar dados em uma única lista de uma lista aninhada', () => {
    const dados = [[1,1,1],2,[3,3,4],4,5,7,[6,6]];
    const resultadoEsperado = [1,1,1,2,3,3,4,4,5,7,6,6];

    expect(serializarArray(dados)).toStrictEqual(resultadoEsperado);
});
