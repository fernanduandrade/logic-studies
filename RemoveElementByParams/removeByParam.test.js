import removerItens from './removeByParam';

test('Remover itens de uma lista que são passados por parâmetro', () => {
    const dados = [5,4,2,1,3,4,5,3];
    const resultadoEsperado = [4,2,1,4];

    expect(removerItens(dados, 5,3)).toStrictEqual(resultadoEsperado);
});
