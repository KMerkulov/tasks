import views.MainForm;

import javax.swing.*;

public class Main {

    /**
     * Точка входа в приложение
     * @param args
     */
    public static void main(String[] args) {
        JFrame frame = new JFrame("App");

        // Создание основной формы
        MainForm view = new MainForm();
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        frame.setTitle("Pond generator");

        frame.setContentPane(view.mainPanel);


        frame.pack();
        frame.setSize(800 , 580);
        frame.setResizable(false);
        frame.setVisible(true);
    }
}
