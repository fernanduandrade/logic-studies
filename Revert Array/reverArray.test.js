import reverterArray from './revertArray';

test('Reverter uma lista sem usar os métodos do Array.prototype', () => {

		const dados = ["a",2,3,"@",111,"Cerveja"];
		const resultadoEsperado = ["Cerveja",111,"@",3,2,"a"]; 

		expect(reverterArray(dados)).toStrictEqual(resultadoEsperado);
});
