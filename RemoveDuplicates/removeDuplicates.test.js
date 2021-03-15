const filtrarArray = require('./removeDuplicates');

test('Remover valores duplicados de uma lista', () => {
    const dados = [1,1,1,2,3,3,4,4,5,7,6,6];
    const resultadoEsperado = [1,2,3,4,5,7,6];

    expect(filtrarArray(dados)).toStrictEqual(resultadoEsperado);
});
