const criarArray = require('./createArray');

test('Criar uma array passando uma quantidade e o seu valor', () => {
    expect(criarArray(5, "a")).toStrictEqual(["a", "a", "a", "a", "a"]);
});
