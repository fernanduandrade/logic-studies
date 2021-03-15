import matchValores from './matchValores';

test('Criar uma lista com os valores de duas listas que dão match', () => {
    const array1 = [1,2,7,8,9];
    const array2 = [3,4,7,8,9];

    const resultadoEsperado = [7,8,9]

    expect(matchValores(array1, array2)).toStrictEqual(resultadoEsperado);
});	
