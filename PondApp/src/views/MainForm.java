package views;

import models.enums.PondEntity;
import models.pond.Pond;
import models.pond.PondMap;
import models.pond.PondPoint;

import javax.swing.*;
import java.awt.*;

public class MainForm{

    // Значения пруда по умолчания
    private Integer hPondSize = 100;
    private Integer vPondSize = 100;
    private Integer pointSize = 5;

    private Pond pond;
    public JPanel mainPanel;
    private JButton stateButton;
    private JPanel pondPanel;
    private JPanel pondConfigPanel;
    private JSpinner luceSpinner;
    private JSpinner crucianSpinner;
    private JSpinner seaWeedSpinner;
    private JSpinner rockSpinner;
    private JSpinner seaWeedLifeTimeSpinner;
    private JSpinner seaWeedGrowthRateSpinner;
    private JSpinner stepDelaySpinner;
    private JSpinner crucianLifeTimeSpinner;
    private JSpinner luceLifeTimeSpinner;
    private JSpinner crucialGrowthRateSpinner;
    private JSpinner luceGrowthRateSpinner;

    public MainForm(){
        pond = new Pond(hPondSize , vPondSize);
        initializeForm();
    }

    /**
     * Инициализация формы
     */
    private void initializeForm() {

        // Установка параметров для камней
        initializeRock();
        // Установка параметров для водорослей
        initializeSeaWeed();
        // Установка параметров для карасей
        initializeCrucial();
        // Установка параметров для щук
        initializeLuce();

        // Установка параметра - время между тактами
        stepDelaySpinner.setModel(createSpinnerModel(100 , 100 , 15000,100));
        // Установка размеров окна по умолчания
        pondPanel.setSize(new Dimension(500 , 500));
        addListeners();
    }

    /**
     * Установка параметров для щук
     */
    private void initializeLuce() {
        luceSpinner.setModel(createSpinnerModel());
        luceLifeTimeSpinner.setModel(createSpinnerModel(50 , 1 , 100 , 1));
        luceGrowthRateSpinner.setModel(createSpinnerModel(4 , 1 , 100 , 1));
    }

    /**
     * Установка параметров для карасей
     */
    private void initializeCrucial() {
        crucianSpinner.setModel(createSpinnerModel());
        crucianLifeTimeSpinner.setModel(createSpinnerModel(50 , 1 , 100 , 1));
        crucialGrowthRateSpinner.setModel(createSpinnerModel(4 , 1 , 100 , 1));
    }

    /**
     * Установка параметров для камней
     */
    private void initializeRock() {
        rockSpinner.setModel(createSpinnerModel());
    }

    /**
     * Установка параметров для водорослей
     */
    private void initializeSeaWeed() {
        seaWeedSpinner.setModel(createSpinnerModel());
        seaWeedGrowthRateSpinner.setModel(createSpinnerModel());
        seaWeedLifeTimeSpinner.setModel(createSpinnerModel(15 , 1 , 100 , 1));

    }

    /**
     * Создание стандартной модели для спиннера
     * @param value - значение по умолчанию
     * @param minValue - минимальное допустимое значение
     * @param maxValue - максимально допустимое значение
     * @param stepSize - шаг
     * @return модель спиннера
     */
    private SpinnerModel createSpinnerModel(int value , int minValue  , int maxValue , int stepSize) {
        return new SpinnerNumberModel(value , minValue , maxValue , stepSize);
    }

    /**
     * Перегрузка метода для модели спиннера с параметрами по умолчанию
     * @return модель спиннера
     */
    private SpinnerModel createSpinnerModel() {
        return createSpinnerModel(5 , 1, 100, 1);
    }

    /**
     * Создание обработчиков событий
     */
    private void addListeners() {

        // Обработка события нажатия нап кнопку старт/стоп
        stateButton.addActionListener(e -> {
            if (!pond.isStarted()){
                startPond();
            } else {
                stopPond();
            }
        });
        // Обработка события пруда
        pond.addMyEventListener(evt -> refreshPondDraw());
    }

    /**
     * Функция остановки жизни в пруду и его очистки
     */
    private void stopPond() {
        stateButton.setText("Start");
        pond.stop();
        pond.reset();
        clearPondDrawPanel();
    }

    /**
     * Функция запуска имитации жизни в пруду
     */
    private void startPond() {
        stateButton.setText("Stop");
        Integer stepDelay = (Integer) stepDelaySpinner.getValue();

        // Добавление объектов в пруд, в зависимости от параметров пользователя
        pond.addObjects((Integer)rockSpinner.getValue() , PondEntity.Rock , 0 , 0);
        pond.addObjects((Integer)seaWeedSpinner.getValue() , PondEntity.SeaWeed , (Integer) seaWeedLifeTimeSpinner.getValue() , (Integer) seaWeedGrowthRateSpinner.getValue());
        pond.addObjects((Integer)crucianSpinner.getValue() , PondEntity.Crucian , (Integer) crucianLifeTimeSpinner.getValue() , (Integer) crucialGrowthRateSpinner.getValue());
        pond.addObjects((Integer)luceSpinner.getValue() , PondEntity.Luce , (Integer) luceLifeTimeSpinner.getValue() , (Integer) luceGrowthRateSpinner.getValue());

        pond.setStepDelay(stepDelay);

        // Запуск пруда
        pond.start();
    }

    /**
     * Очистка пруда
     */
    private void clearPondDrawPanel() {
        pondPanel.removeAll();
        pondPanel.revalidate();
}

    /**
     * Обновление состояния пруда
     */
    private void refreshPondDraw() {
        clearPondDrawPanel();
        JPanel pondDrawPanel = createPondDrawPanel();
        pondDrawPanel.setLayout(new BorderLayout());
        pondPanel.add(pondDrawPanel);
        pondDrawPanel.revalidate();
    }

    /**
     * Создание новой панели с текущим состояние пруда
     * @return панель
     */
    private JPanel createPondDrawPanel() {
        return new JPanel() {
            @Override
            public void paintComponent(Graphics g) {
                super.paintComponent(g);

                if (pond == null || !pond.isStarted()) {
                    return;
                }

                PondMap pondMap = pond.getPondMap();
                for (int i = 0; i < hPondSize; i++) {
                    for (int j = 0; j < vPondSize; j++) {
                        PondPoint point = pondMap.get(i, j);
                        Color currentColor = point.getColor();
                        if (currentColor == null){
                            continue;
                        }
                        g.setColor(currentColor);
                        g.fillRect(i * pointSize , j * pointSize , pointSize,pointSize);
                    }
                }
            }
        };
    }
}
