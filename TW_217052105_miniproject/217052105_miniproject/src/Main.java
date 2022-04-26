
import javafx.application.Application; 
import javafx.scene.Scene; 
import javafx.stage.Stage;
import udp.SceneController; 
         
public class Main extends Application { 
	Stage stage;
	
	
	
	
	 public static void main(String args[]){ 
	      launch(args); 
	      
	       
	} 
	 
   @Override 
   public void start(Stage primaryStage) throws Exception {

		stage=primaryStage;
		SceneController home=new SceneController(stage);
		stage.setTitle("Home");
		Scene scene=new Scene(home,400,400);
		stage.setScene(scene);
		stage.show();
		
	}
	
  
}