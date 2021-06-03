/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tururu;

/**
 *
 * @author fernando
 */
import java.util.Arrays;

public class Tururu {
    
    public static void main(String[] args) {

        int coeficienteA = Integer.parseInt(args[0]);

        int coeficienteB = Integer.parseInt(args[1]);

        int coeficienteC = Integer.parseInt(args[2]);

        int deltaDiscritante = discritante(coeficienteA, coeficienteB, coeficienteC);

        int[] resutlado = (deltaDiscritante >= 0) ? calcularRaizes(deltaDiscritante, coeficienteA, coeficienteB) : resultadoNegativo(deltaDiscritante);

        System.out.println(Arrays.toString(resutlado));
        System.out.println(deltaDiscritante);
    }

    public static int discritante(int a, double b, int c) {
        int coeficienteB  = (int) Math.pow(b, 2);

        int delta = coeficienteB - 4 * a * c;

        return delta;
    }
    
    public static int[] calcularRaizes(int delta, int a, int b) {
        int xPositiva = (-(b) + ((int)Math.sqrt(delta))) / (2 * a);

        int xNegativa = (-(b) - ((int)Math.sqrt(delta))) / (2 * a);

        return new int[] { xPositiva, xNegativa};
    }

    public static int[] resultadoNegativo (int delta) {

        int valorDeltaNegativo = 0;
        
        return new int[] { valorDeltaNegativo };
    }
}
