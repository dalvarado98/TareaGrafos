/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package graphsimulation;

import edu.structures.core.GraphController;
import java.util.Scanner;

/**
 *
 * @author Daniel_Alvarado
 */
public class GraphSimulation {

    /**
     * @param args the command line arguments
     */
    static GraphController controller = new GraphController();

    public static void main(String[] args) {
        boolean repeatMenu;
        do {
            repeatMenu = menu();
        } while (repeatMenu);
        
    }

    public static boolean menu() {
        boolean repeat = false;
        try {
            System.out.println("Opciones\n1. Ingresar nodo\n2. Ingresar link\n3. Ver grafo\n4. Salir\nIngrese la opción deseada");
            Scanner sc = new Scanner(System.in);
            int opc = sc.nextInt();
            switch (opc) {
                case 1:
                    if (controller.addNode()) {
                        System.out.println("Dato agregado");
                    } else {
                        System.out.println("No agregado");
                    }
                    repeat = true;
                    break;
                case 2:
                    if (controller.addLinkToNodes()) {
                        System.out.println("Link agregado");
                    } else {
                        System.out.println("No agregado");
                    }
                    repeat = true;
                    break;
                case 3:
                    controller.displayNodes();
                    repeat = true;
                    break;
                case 4:
                    System.out.println("Saliendo");
                    break;
            }
        } catch (Exception ex) {
            System.out.println("Opción no valida");
            return true;
        }
        return repeat;
    }

}
