const dividirArray = require('./divideArray');

test('Transformar uma lista em uma lista aninhada baseado no valor passado por parâmetro', () => {
    const dados = [1,1,1,2,3,3,4,4,5,7,6,6];
    const resultadoEsperado = [[1,1,1],[2,3,3],[4,4,5],[7,6,6]];

    expect(dividirArray(dados, 3)).toStrictEqual(resultadoEsperado);
});
