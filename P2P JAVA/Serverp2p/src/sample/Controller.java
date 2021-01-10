package sample;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.stage.FileChooser;
import javafx.stage.Stage;
import javafx.stage.StageStyle;

import java.io.*;
import java.net.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Optional;

public class Controller {

    public static Stage stage;
    public ServerSocket serversocket;
    public static Scene scene;
    public ActionEvent ae;
    public static int x=1;
    public int kb;
    public FileOutputStream fis;
    public OutputStream out;
    public File file;
    public Socket clientsocket;

    @FXML
    public Label serverrun;

    @FXML
    private Label filewait;

    @FXML
    private Label serverstatus;

    @FXML
    private Button closebutton;

    @FXML
    private Button sendbutton;

    @FXML
    private Button selectfilebutton;

    @FXML
    private Button okbutton;

    @FXML
    private Button backbutton;

    @FXML
    private TextField ipaddresstext;

    @FXML
    private TextField porttext;


    public void Serverstart(ActionEvent actionEvent) {
        try {
            FXMLLoader fxmlLoader = new FXMLLoader();
            fxmlLoader.setLocation(getClass().getResource("serverwindow.fxml"));
            scene = new Scene(fxmlLoader.load(), 600, 400);
            stage = new Stage();
            stage.setTitle("Server Window");
            stage.setScene(scene);
            stage.initStyle(StageStyle.TRANSPARENT);
            stage.show();
            serverrun=(Label) scene.lookup("#serverrun");
            filewait =(Label) scene.lookup("#filewait");
            closebutton=(Button) scene.lookup("#closebutton");
            backbutton=(Button) scene.lookup("#backbutton");
            selectfilebutton=(Button) scene.lookup("#selectfilebutton");
            sendbutton=(Button) scene.lookup("#sendbutton");
            okbutton=(Button) scene.lookup("#okbutton");
serverrun.setVisible(false);
filewait.setVisible(false);
closebutton.setVisible(false);
        }
        catch (IOException e) {
            //e.printStackTrace();
        }    }

    public void clientstart(ActionEvent actionEvent) throws IOException {
        try {
            FXMLLoader fxmlLoader = new FXMLLoader();
            fxmlLoader.setLocation(getClass().getResource("clientwindow.fxml"));
            scene = new Scene(fxmlLoader.load(), 672, 400);
            stage = new Stage();
            stage.setTitle("Client Window");
            stage.setScene(scene);
            stage.show();
            ipaddresstext=(TextField) scene.lookup("#ipaddresstext");
            serverstatus=(Label) scene.lookup("#serverstatus");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void runserver(ActionEvent actionEvent) throws IOException {
        TextInputDialog dialog = new TextInputDialog("100");
        dialog.setTitle("FILE SIZE LIMITOR");
        dialog.setHeaderText("");
        dialog.setContentText("Please enter the max file size:");
        Optional<String> result = dialog.showAndWait();
        try{
            kb=Integer.parseInt(result.get());
            if(kb<=0)
                kb=100;

        }
        catch (Exception e)
        {
            kb=100;
        }
        new Thread(()->{
            try {
                runserveron();
            } catch (IOException e) {
              //  e.printStackTrace();
            }
        }).start();

    }

    private void runserveron() throws IOException {
        try {
            serversocket = new ServerSocket(1134, 10);
            serverrun.setVisible(true);
            filewait.setVisible(true);
            closebutton.setVisible(true);
            backbutton.setVisible(false);
            Socket client = serversocket.accept();
            client.setReceiveBufferSize(kb);
            InputStream in = client.getInputStream();
            fis = new FileOutputStream("D:\\RecievedFile\\test" + x + ".txt");
            out = fis;
            int count;
            byte[] buffer = new byte[kb];
                while ((count = in.read(buffer)) > 0) {
                    out.write(buffer, 0, count);
                }
                x++;

            in.close();
            out.close();
            client.close();
            fis.close();
            serversocket.close();
            runserveron();
        }
        catch (Exception e)
        {
            System.out.println("Buffer size crossed");
            serversocket.close();
            runserveron();
        }
    }

    public void close(ActionEvent actionEvent) throws IOException {
        try {
            serversocket.close();
            stage.close();
fis.close();
out.close();
Files.delete(Paths.get("D:\\RecievedFile\\test"+x+".txt"));
            Alert alert=new Alert(Alert.AlertType.INFORMATION);
            alert.setTitle("FILES RECIEVED");
            alert.setHeaderText("");
            alert.setContentText("Number of FILES Recieved : "+(x-1));
            alert.show();
        }
        catch (Exception e)
        {
     stage.close();
        }
    }

    public void back(ActionEvent actionEvent) {
        stage.close();
    }

    public void connectclient(ActionEvent actionEvent) {
       connectclientdone();
    }

    public void selectfile(ActionEvent actionEvent) {
       FileChooser fileChooser = new FileChooser();
        fileChooser.setTitle("Open Resource File");
        try {
            file=fileChooser.showOpenDialog(stage);
            if(file.isFile())
            {
            sendbutton.setVisible(true);
            selectfilebutton.setVisible(false);
        }}
        catch (Exception w)
        {
        }
    }

    public void sendfile(ActionEvent actionEvent) {
try{
    byte[] bytes = new byte[16 * 1024];
    InputStream in = new FileInputStream(file);
    OutputStream out = clientsocket.getOutputStream();

    int count;
    while ((count = in.read(bytes)) > 0) {
        out.write(bytes, 0, count);
    }

    out.close();
    in.close();
    clientsocket.close();
    System.out.println("done");
    sendbutton.setVisible(false);
    connectclientdone();
}
catch (Exception e)
{

}
    }

    private void connectclientdone() {
        try
        {
            String ipaddress = ipaddresstext.getText();
            InetAddress addr = InetAddress.getByName(ipaddress);
            int port = Integer.parseInt(porttext.getText());
            SocketAddress sockaddr = new InetSocketAddress(addr, port);
            clientsocket = new Socket();
            clientsocket.connect(sockaddr);
            okbutton.setVisible(false);
            serverstatus.setText("ONLINE");
            serverstatus.setStyle("-fx-background-color: green;");
            selectfilebutton.setVisible(true);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            serverstatus.setText("OFFLINE");
            serverstatus.setStyle("-fx-background-color: red;");
        }
    }


    public void closescreen(ActionEvent actionEvent) {
        stage.close();
    }
}
