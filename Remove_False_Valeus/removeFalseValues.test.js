const removerInvalidos = require('./removeFalseValues');

test('Remover valores falsos e inválidos de uma lista', () => {
    const dados = [1,2,"", false, 0,4, 5, 'x', 'nando', 0, undefined, null];
    const resultadoEsperado = [1,2,4,5,'x','nando'];

    expect(removerInvalidos(dados)).toStrictEqual(resultadoEsperado);
});
