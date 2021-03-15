const compararArray = require('./compareArrays');

test('Comparar duas listas e retornar true se forem iguais', () => {
    const array1 = [1,1,1,2,3,3,4,4,5,7,6,6];
    const array2 = [1,1,1,2,3,3,4,4,5,7,6,6];

    expect(compararArray(array1, array2)).toStrictEqual(true);
});
