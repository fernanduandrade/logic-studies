const  arrayParaObject = require('./arrayToObject');

test('Converter uma lista para o tipo Object', () => {
    const dados = [["c",2],["d",4]];
    const resultadoEsperado = {c: 2, d: 4};
    expect(arrayParaObject(dados)).toStrictEqual(resultadoEsperado);
});
