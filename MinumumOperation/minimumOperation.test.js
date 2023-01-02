const findMinimumOperation = require('./minimumOperation');





it(`Dado um elemento inteiro ‘N’, a tarefa é encontrar o número mínimo de operações 
    que precisam ser executadas para tornar ‘N’ igual a 1.Criar uma array passando uma quantidade e o seu valor`, () => {
    const findMinimumOf8 = findMinimumOperation()
    expect(findMinimumOf8(8)).toStrictEqual(3);
})

