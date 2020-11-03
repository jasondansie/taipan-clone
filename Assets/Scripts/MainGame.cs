using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MainGame : MonoBehaviour {


	public Text Location;
	public Text Guns;
	public Text Debt;
	public Text Hold;
	public Text Status;
	public Text Vacant;
	public Text Used;
	public Text W_Opium;
	public Text W_Silk;
	public Text W_Arms;
	public Text W_Generals;
	public Text H_Opium;
	public Text H_Silk;
	public Text H_Arms;
	public Text H_Generals;
	public Text T_Opium;
	public Text T_Silk;
	public Text T_Arms;
	public Text T_Generals;
	public Text Firm;
	public Text Cash;
	public Text Report;
	public Text Bank;

	public Button Yes_Button;
	public Button No_Button;
	public Button None_Button;
	public Button All_Button;
	public Button Del_Button;
	public Button Enter_Button;
	public Button One_Button;
	public Button Two_Button;
	public Button Three_Button;
	public Button Four_Button;
	public Button Five_Button;
	public Button Six_Button;
	public Button Seven_Button;
	public Button Eight_Button;
	public Button Nine_Button;
	public Button Zero_Button;
	public Button Buy_Button;
	public Button Sell_Button;
	public Button QuitTrading_Button;
	public Button TransferCargo_Button;
	public Button VisitBank_Button;
	public Button HongKong_Button;
	public Button Shanghai_Button;
	public Button Nagasaki_Button;
	public Button Saigon_Button;
	public Button Manila_Button;
	public Button Singapore_Button;
	public Button Batavia_Button;

	public Canvas Yes_Canvas;
	public Canvas No_Canvas;
	public Canvas All_Canvas;
	public Canvas None_Canvas;
	public Canvas None1_Canvas;
	public Canvas Del_Canvas;
	public Canvas Enter_Canvas;
	public Canvas One_Canvas;
	public Canvas Two_Canvas;
	public Canvas Three_Canvas;
	public Canvas Four_Canvas;
	public Canvas Five_Canvas;
	public Canvas Six_Canvas;
	public Canvas Seven_Canvas;
	public Canvas Eight_Canvas;
	public Canvas Nine_Canvas;
	public Canvas Zero_Canvas;
	public Canvas Amount;
	public Canvas Buy_Canvas;
	public Canvas Sell_Canvas;
	public Canvas QuitTrading_Canvas;
	public Canvas TransferCargo_Canvas;
	public Canvas VisitBank_Canvas;
	public Canvas General_Canvas;
	public Canvas Arms_Canvas;
	public Canvas Silk_Canvas;
	public Canvas Opium_Canvas;
	public Canvas HongKong_Canvas;
	public Canvas Shanghai_Canvas;
	public Canvas Nagasaki_Canvas;
	public Canvas Saigon_Canvas;
	public Canvas Manila_Canvas;
	public Canvas Singapore_Canvas;
	public Canvas Batavia_Canvas;
	public Canvas Places_Canvas;


	public InputField AmountText;

	string FirmText = "Firm: ";
	string ReportText = "Comprador's Report  \n ";
	string ReportText2 =	"Li Yuen asks ";
	string ReportText3 = " in donation\n to the temple of Tin Hau, the Sea Goddess. \nWill you pay? ";
	string GameState;
	int PurchasePower = 0;
	int BuyPower = 0;

	Game_Manager _GM;
	GameObject GameManager;
	Player _Player;
	Ship _Ship;
	Warehouse _Warehouse;
	Trade _Trade;





	// Use this for initialization
	void Start () {
		
		GameManager = GameObject.Find ("GameManager");
		_GM = GameManager.gameObject.GetComponent( typeof(Game_Manager) ) as Game_Manager;
		_Player = GameManager.gameObject.GetComponent( typeof(Player) ) as Player;
		_Ship = GameManager.gameObject.GetComponent( typeof(Ship) ) as Ship;
		_Warehouse = GameManager.gameObject.GetComponent( typeof(Warehouse) ) as Warehouse;
		_Trade = GameManager.gameObject.GetComponent( typeof(Trade) ) as Trade;

		Yes_Canvas = Yes_Canvas.GetComponent<Canvas> ();
		No_Canvas = No_Canvas.GetComponent<Canvas> ();
		All_Canvas = All_Canvas.GetComponent<Canvas> ();
		None_Canvas = None_Canvas.GetComponent<Canvas> ();
		None1_Canvas = None1_Canvas.GetComponent<Canvas> ();
		Del_Canvas = Del_Canvas.GetComponent<Canvas> ();
		Enter_Canvas = Enter_Canvas.GetComponent<Canvas> ();
		One_Canvas = One_Canvas.GetComponent<Canvas> ();
		Two_Canvas = Two_Canvas.GetComponent<Canvas> ();
		Three_Canvas = Three_Canvas.GetComponent<Canvas> ();
		Four_Canvas = Four_Canvas.GetComponent<Canvas> ();
		Five_Canvas = Five_Canvas.GetComponent<Canvas> ();
		Six_Canvas = Six_Canvas.GetComponent<Canvas> ();
		Seven_Canvas = Seven_Canvas.GetComponent<Canvas> ();
		Eight_Canvas = Eight_Canvas.GetComponent<Canvas> ();
		Nine_Canvas = Nine_Canvas.GetComponent<Canvas> ();
		Zero_Canvas = Zero_Canvas.GetComponent<Canvas> ();
		Six_Canvas = Six_Canvas.GetComponent<Canvas> ();
		Seven_Canvas = Seven_Canvas.GetComponent<Canvas> ();
		Eight_Canvas = Eight_Canvas.GetComponent<Canvas> ();
		Nine_Canvas = Nine_Canvas.GetComponent<Canvas> ();
		Zero_Canvas = Zero_Canvas.GetComponent<Canvas> ();
		Buy_Canvas = Buy_Canvas.GetComponent<Canvas> ();
		Sell_Canvas = Sell_Canvas.GetComponent<Canvas> ();
		QuitTrading_Canvas = QuitTrading_Canvas.GetComponent<Canvas> ();
		TransferCargo_Canvas = TransferCargo_Canvas.GetComponent<Canvas> ();
		VisitBank_Canvas = VisitBank_Canvas.GetComponent<Canvas> ();
		General_Canvas = General_Canvas.GetComponent<Canvas> ();
		Arms_Canvas = Arms_Canvas.GetComponent<Canvas> ();
		Silk_Canvas = Silk_Canvas.GetComponent<Canvas> ();
		Opium_Canvas = Opium_Canvas.GetComponent<Canvas> ();
		HongKong_Canvas = HongKong_Canvas.GetComponent<Canvas> ();
		Shanghai_Canvas = Shanghai_Canvas.GetComponent<Canvas> ();
		Nagasaki_Canvas = Nagasaki_Canvas.GetComponent<Canvas> ();
		Saigon_Canvas = Saigon_Canvas.GetComponent<Canvas> ();
		Manila_Canvas = Manila_Canvas.GetComponent<Canvas> ();
		Singapore_Canvas = Singapore_Canvas.GetComponent<Canvas> ();
		Batavia_Canvas = Batavia_Canvas.GetComponent <Canvas> ();
		Places_Canvas = Places_Canvas.GetComponent <Canvas> ();

		Amount = Amount.GetComponent<Canvas> ();
		Amount.enabled = false;

		All_Canvas.enabled = false;
		None_Canvas.enabled = false;
		None1_Canvas.enabled = false;
		Del_Canvas.enabled = false;
		Enter_Canvas.enabled = false;
		One_Canvas.enabled = false;
		Two_Canvas.enabled = false;
		Three_Canvas.enabled = false;
		Four_Canvas.enabled = false;
		Five_Canvas.enabled = false;
		Six_Canvas.enabled = false;
		Seven_Canvas.enabled = false;
		Eight_Canvas.enabled = false;
		Nine_Canvas.enabled = false;
		Zero_Canvas.enabled = false;
		Buy_Canvas.enabled = false;
		Sell_Canvas.enabled = false;
		QuitTrading_Canvas.enabled = false;
		TransferCargo_Canvas.enabled = false;
		VisitBank_Canvas.enabled = false;
		General_Canvas.enabled = false;
		Silk_Canvas.enabled = false;
		Arms_Canvas.enabled = false;
		Opium_Canvas.enabled = false;
		HongKong_Canvas.enabled = false;
		Shanghai_Canvas.enabled = false;
		Nagasaki_Canvas.enabled = false;
		Saigon_Canvas.enabled = false;
		Manila_Canvas.enabled = false;
		Singapore_Canvas.enabled = false;
		Batavia_Canvas.enabled = false;
		Places_Canvas.enabled = false;



		Debt = Debt.GetComponent<Text> ();
		Cash = Cash.GetComponent<Text> ();
		Bank = Bank.GetComponent<Text> ();



		if (_GM.get_StartChoice () == 1) {

			GameState = "start";
			Debug.Log (GameState);
			_Player.Cash = 400;
			Cash.text =  _Player.Cash.ToString();
			_Player.Debt = 5000;
			Debt.text = _Player.Debt.ToString();

			Debug.Log ("Choice is 1");
		} 
		else {
			

			Debug.Log (GameState);
			_Ship.Guns = 5;
			Guns.text =  _Ship.Guns.ToString();
			Debt.text = "0";
		}
			
		Location = Location.GetComponent<Text> ();
		Location.text = _Ship.Location;


		Vacant = Vacant.GetComponent<Text> ();
		Vacant.text = _Warehouse.Vacant.ToString();
		Used = Used.GetComponent<Text> ();
		Used.text = _Warehouse.In_Use.ToString();
		W_Opium = W_Opium.GetComponent<Text> ();
		W_Opium.text = _Warehouse.Opium.ToString();
		W_Silk = W_Silk.GetComponent<Text> ();
		W_Silk.text = _Warehouse.Silk.ToString();
		W_Arms = W_Arms.GetComponent<Text> ();
		W_Arms.text = _Warehouse.Arms.ToString();
		W_Generals = W_Generals.GetComponent<Text> ();
		W_Generals.text = _Warehouse.General.ToString();


		H_Opium = H_Opium.GetComponent<Text> ();
		H_Opium.text = _Ship.Opium.ToString();
		H_Silk = H_Silk.GetComponent<Text> ();
		H_Silk.text = _Ship.Silk.ToString();
		H_Arms = H_Arms.GetComponent<Text> ();
		H_Arms.text = _Ship.Arms.ToString();
		H_Generals = H_Generals.GetComponent<Text> ();
		H_Generals.text = _Ship.General.ToString();
		Hold = Hold.GetComponent<Text> ();
		Hold.text = _Ship.Hold.ToString();
		Status = Status.GetComponent<Text> ();
		Status.text = _Ship.Status.ToString();
		Guns = Guns.GetComponent<Text> ();
		Guns.text = _Ship.Guns.ToString();


		Firm = Firm.GetComponent<Text> ();
		if(_GM.get_PlayerName() == ""){

			_GM.set_PlayerName ("Nobel House");
		}
		Firm.text = FirmText + " " + _GM.get_PlayerName() + ", " + _Ship.Location;

		_Player.Donation = Random.Range (5, 200);
		Debug.Log (_Player.Donation);

		Report.text = ReportText + ReportText2 + _Player.Donation  + ReportText3;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Subtract_Donation(){
		
		_Player.Cash = _Player.Cash - _Player.Donation ;
		Cash.text =  _Player.Cash.ToString();
		Debug.Log (_Player.Cash);
	}
	void MoneyLender(){

		_GM.set_GameState("moneylender");
		Debug.Log (_GM.get_GameState());
		LoadYesNo ();
		Debug.Log (_GM.get_GameState());
		Report.text = ReportText + "Do you have business with\n" + "Elder Brother Wu," + "\nthe monelender?";
	}
	void BuyScreen(){
		
		_GM.set_GameState("buying");
		Debug.Log (_GM.get_GameState());
		LoadCurrentTrade4BuySell ();
		LoadBuySellButtons ();
		None_Canvas.enabled = true;
		//None_Canvas.transform.position = new Vector3 (431,268,0);

	}
	void SellScreen(){

		_GM.set_GameState("selling");
		Debug.Log (_GM.get_GameState());
		LoadCurrentTrade4BuySell ();
		LoadBuySellButtons ();
		None_Canvas.enabled = true;
		//None_Canvas.transform.position = new Vector3 (431,268,0);

	}
	void MoneyLenderPayBack(){

		_GM.set_GameState("MoneyLenderPayBack");
		Debug.Log (_GM.get_GameState());
		DisableAgree ();
		Report.text = ReportText + "How Much do you wish to pay off?";
		LoadNumbers ();
		LoadAllNone ();
		LoadAmount ();

	}
	void MoneyLenderBorrow(){

		_GM.set_GameState("MoneyLenderBorrow");
		Debug.Log (_GM.get_GameState());
		DisableAgree ();
		AmountText.text = "";
		Report.text = ReportText + "How Much do you wish to Borrow?";
		LoadNumbers ();
		LoadNone1 ();
		None1_Canvas.transform.position = new Vector3 (260,220,0);
		LoadAmount ();

	}

	void LoadTrade(){
		_GM.set_GameState("trading");
		Debug.Log (_GM.get_GameState());
		DisableAgree ();
		DisableAmount ();
		DisableNumbers ();

		_Trade.LoadNewTrade ();
		LoadTradeButtons ();

		Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "Shall I,";
	}
	public void LoadSellScreen(){

		AmountText.text += 0.ToString();
	}
	public void LoadCityScreen(){

		AmountText.text += 0.ToString();
	}
	public void LoadTransferScreen(){

		AmountText.text += 0.ToString();
	}
	public void LoadVisitBankScreen(){
		
		_GM.set_GameState("bankdeposit");
		Debug.Log (_GM.get_GameState());
		DisableTradeButtons ();
		Report.text = ReportText + "\n\n\n How much will you deposit";
		LoadAmount ();
		LoadNumbers ();
		LoadAllNone ();
		//None_Canvas.transform.position = new Vector3 (314, 280, 0);
		AmountText.text = "";
	}
	public void LoadBankWithdrawScreen(){
		
		_GM.set_GameState("bankwithdraw");
		Debug.Log (_GM.get_GameState());
		DisableTradeButtons ();
		Report.text = ReportText + "\n\n\n How much will you withdraw";
		LoadAmount ();
		LoadNumbers ();
		//None_Canvas.transform.position = new Vector3 (314, 280, 0);
		LoadAllNone ();
	}
	void LoadCurrentTrade(){

		DisableNumbers ();
		DisableAgree ();
		DisableAmount ();
		LoadTradeButtons ();
		//_Trade.LoadCurrentTrade ();
		Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "Shall I,";
	}
	void LoadCurrentTrade4BuySell(){
		

		if (_GM.get_GameState () == "buying\t") {

			Debug.Log (_GM.get_GameState());

			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "What do you wish me to  buy, Taipan?";
			DisableTradeButtons ();
		} 
		else {

			Debug.Log (_GM.get_GameState());

			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "What do you wish me to  sell, Taipan?";
			DisableTradeButtons ();
		}

	}
	void LoadPurchaseScreen(int sel){

		AmountText.text = "";
		_GM.set_GameState("purchasing");
		Debug.Log (_GM.get_GameState());

		if (sel == 1) {
			PurchasePower = _Player.Cash / _Trade.get_General();
			Debug.Log ("puchchase = " + PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much General Cargo shall I buy, Taipan?";
		} 
		else if (sel == 2) {

			PurchasePower = _Player.Cash / _Trade.get_Arms();
			Debug.Log ("puchchase = " + PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much Arms shall I buy, Taipan?";
		} 
		else if (sel == 3) {

			PurchasePower = _Player.Cash / _Trade.get_Silk();
			Debug.Log ("puchchase = " + PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much Silk shall I buy, Taipan?";
		} 
		else {

			PurchasePower = _Player.Cash / _Trade.get_Opium();
			Debug.Log ("puchchase = " + PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much Opium shall I buy, Taipan?";
		} 

		DisableBuySellButtonsButtons ();
		LoadAmount ();
		LoadAllNone ();
		//None_Canvas.transform.position = new Vector3 (325, 280, 0);
		LoadNumbers ();
	}	
	void LoadSalesScreen(int sel){

		 
		_GM.set_GameState("selling");
		AmountText.text = "";

		Debug.Log (_GM.get_GameState());
		if (sel == 1) {
			PurchasePower = _Ship.General * _Trade.get_General();
			Debug.Log (PurchasePower.ToString());

			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much General Cargo shall I Sell, Taipan?";
		} 
		else if (sel == 2) {
			
			PurchasePower =_Ship.Arms * _Trade.get_Arms();
			Debug.Log (PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much Arms shall I Sell, Taipan?";
		} 
		else if (sel == 3) {

			PurchasePower = _Ship.Silk * _Trade.get_Silk();
			Debug.Log (PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much Silk shall I Sell, Taipan?";
		} 
		else {

			PurchasePower = _Ship.Opium * _Trade.get_Opium();
			Debug.Log (PurchasePower.ToString());
			Report.text = ReportText + _Trade.greet + _Trade.OpiumText + _Trade.SilkText + _Trade.ArmsText + _Trade.GeneralText + "How Much Opium shall I Sell, Taipan?";
		} 

		DisableBuySellButtonsButtons ();
		LoadAmount ();
		LoadAllNone ();
		//None_Canvas.transform.position = new Vector3 (325, 280, 0);
		LoadNumbers ();

	}		  




	void LoadTradeButtons(){
		
		Buy_Canvas.enabled = true;
		Sell_Canvas.enabled = true;
		QuitTrading_Canvas.enabled = true;
		TransferCargo_Canvas.enabled = true;
		VisitBank_Canvas.enabled = true;
	}
	void DisableTradeButtons(){

		Buy_Canvas.enabled = false;
		Sell_Canvas.enabled = false;
		QuitTrading_Canvas.enabled = false;
		TransferCargo_Canvas.enabled = false;
		VisitBank_Canvas.enabled = false;
	}
	void LoadBuySellButtons(){
		
		General_Canvas.enabled = true;
		Arms_Canvas.enabled = true;
		Silk_Canvas.enabled = true;
		Opium_Canvas.enabled = true;
	}
	void DisableBuySellButtonsButtons(){

		General_Canvas.enabled = false;
		Arms_Canvas.enabled = false;
		Silk_Canvas.enabled = false;
		Opium_Canvas.enabled = false;
		None_Canvas.enabled = false;
	}

	void LoadYesNo(){
		Yes_Canvas.enabled = true;
		No_Canvas.enabled = true;
	}
	void LoadNumbers(){
		
		One_Canvas.enabled = true;
		Two_Canvas.enabled = true;
		Three_Canvas.enabled = true;
		Four_Canvas.enabled = true;
		Five_Canvas.enabled = true;
		Six_Canvas.enabled = true;
		Seven_Canvas.enabled = true;
		Eight_Canvas.enabled = true;
		Nine_Canvas.enabled = true;
		Zero_Canvas.enabled = true;
		Enter_Canvas.enabled = true;
		Del_Canvas.enabled = true;
	}
	void DisableNumbers(){

		One_Canvas.enabled = false;
		Two_Canvas.enabled = false;
		Three_Canvas.enabled = false;
		Four_Canvas.enabled = false;
		Five_Canvas.enabled = false;
		Six_Canvas.enabled = false;
		Seven_Canvas.enabled = false;
		Eight_Canvas.enabled = false;
		Nine_Canvas.enabled = false;
		Zero_Canvas.enabled = false;
		Enter_Canvas.enabled = false;
		Del_Canvas.enabled = false;
	}
	void DisableAgree(){

		Yes_Canvas.enabled = false;
		No_Canvas.enabled = false;
		None1_Canvas.enabled = false;
		None_Canvas.enabled = false;
		All_Canvas.enabled = false;
	}
	void LoadAllNone(){
		
		None_Canvas.enabled = true;
		All_Canvas.enabled = true;
	}
	void LoadNone1(){

		None1_Canvas.enabled = true;
	}
	void LoadAmount(){

		Amount.enabled = true;
	}
	void DisableAmount(){

		Amount.enabled = false;
	}
	void LoadPlaces_Buttons(){

		HongKong_Canvas.enabled = true;
		Shanghai_Canvas.enabled = true;
		Nagasaki_Canvas.enabled = true;
		Saigon_Canvas.enabled = true;
		Manila_Canvas.enabled = true;
		Singapore_Canvas.enabled = true;
		Batavia_Canvas.enabled = true;
		Places_Canvas.enabled = true;
	}
	void DisablePlaces_Buttons(){

		HongKong_Canvas.enabled = false;
		Shanghai_Canvas.enabled = false;
		Nagasaki_Canvas.enabled = false;
		Saigon_Canvas.enabled = false;
		Manila_Canvas.enabled = false;
		Singapore_Canvas.enabled = false;
		Batavia_Canvas.enabled = false;
		Places_Canvas.enabled = false;
	}


	void SwitchScenes(int Sc){
		
		switch(_GM.get_GameState()){

		case "start":
			if (Sc == 1) {

				Subtract_Donation ();
				MoneyLender ();
				break;
			} 
			else {

				MoneyLender ();
				break;
			}
		case "Trading":
			if (Sc == 1) {

				MoneyLender ();
				break;
			} 
			else {

				MoneyLender ();
				break;
			}


		case "moneylender":
			if (Sc == 1) {
				
				MoneyLenderPayBack ();
				break;
			}
			else {


				LoadTrade ();
				break;
			}
		case "MoneyLenderPayBack":
			if (Sc == 1) {
				int am = 0;
				if (AmountText.text == "0") {
					Debug.Log ("flase");
					Debug.Log (AmountText.text);


				} 
				else {
					am = int.Parse (AmountText.text);
				}

				Debug.Log (am);
				if (am <= _Player.Cash) {
					Debug.Log ("less");
					_Player.Cash = _Player.Cash - am;
					_Player.Debt = _Player.Debt - am;
					Cash.text = _Player.Cash.ToString ();
					Debt.text = _Player.Debt.ToString ();
				} 
				else if(am >_Player.Cash) {
					Debug.Log ("great");
					_Player.Debt = _Player.Debt - _Player.Cash;
					_Player.Cash -= _Player.Cash;
					Cash.text = _Player.Cash.ToString ();
					Debt.text = _Player.Debt.ToString ();
				}
				else if(am == 0) {
					Debug.Log ("great");
				}
				else {

					_Player.Debt = _Player.Debt + am;
					Debt.text = _Player.Debt.ToString ();
					_Player.Cash = am;
					Cash.text = _Player.Cash.ToString ();
				} 

				MoneyLenderBorrow ();
				break;
			}
			else {

				MoneyLenderBorrow ();
				break;
			}
		case "MoneyLenderBorrow":
			if (Sc == 1) {

				LoadTrade ();
				break;
			}
			else {

				LoadTrade ();
				break;
			}
		case "bankdeposit":
			if (Sc == 1) {

				int am = int.Parse (AmountText.text);
				if (_Player.Cash >= am) {

					_Player.Bank += am ;
					_Player.Cash -= am;
					Cash.text = _Player.Cash.ToString();
					Bank.text = _Player.Bank.ToString ();
					AmountText.text = "";
					LoadBankWithdrawScreen ();
					break;
				} 
				else {
					
					_Player.Bank = _Player.Cash;
					Bank.text = _Player.Bank.ToString ();
					_Player.Cash = 0;
					Cash.text = _Player.Cash.ToString ();
					AmountText.text = "";
					LoadBankWithdrawScreen ();
					break;
				}
			}
			else {

				LoadBankWithdrawScreen ();
				break;
			}
		case "bankwithdraw":
			if (Sc == 1) {
				
				int am = int.Parse (AmountText.text);
				if (_Player.Bank > am) {

					_Player.Cash += am;
					Cash.text = _Player.Cash.ToString ();
					_Player.Bank -= am;
					Bank.text = _Player.Bank.ToString ();
					AmountText.text = "";
					LoadCurrentTrade ();
					break;

				} else {

					_Player.Cash = _Player.Bank;
					Cash.text = _Player.Cash.ToString ();
					_Player.Bank = 0;
					Bank.text = _Player.Bank.ToString ();
					AmountText.text = "";
					LoadCurrentTrade ();
					break;
				}

			} 
			else {

				LoadCurrentTrade ();
				break;
			}
		case "buying":
			if (Sc == 1) {


				break;
			}
			else {
				
				DisableBuySellButtonsButtons ();
				LoadCurrentTrade ();
				break;
			}
		case "purchasing":
			if (Sc == 1) {
				int am = int.Parse (AmountText.text);
				Debug.Log ("am = " + am);
				if (_Ship.Hold < am) {
					if (_GM.get_CargoChoice () == 1) {
						
						Debug.Log ("purch Over" + _Ship.Hold.ToString ());
						Overloaded ("General", am);
					} else if (_GM.get_CargoChoice () == 2) {

						Debug.Log ("purch Over" + _Ship.Hold.ToString ());
						Overloaded ("Arms", am);
					} else if (_GM.get_CargoChoice () == 3) {

						Debug.Log ("purch Over" + _Ship.Hold.ToString ());
						Overloaded ("Silk", am);
					} 
					else {

						Debug.Log ("purch Over" + _Ship.Hold.ToString ());
						Overloaded ("Silk", am);
					}


				} 
				else {

					if (_GM.get_CargoChoice () == 1) {	
						
						Normal_Trade ("General", am);
					}
					else if(_GM.get_CargoChoice () == 2){
						
						Normal_Trade ("Arms", am);
					}
					else if(_GM.get_CargoChoice () == 3){

						Normal_Trade ("Silk", am);
					}
					else{

						Normal_Trade ("Opium", am);
					}

				}
				break;
			}
			else {

				DisableBuySellButtonsButtons ();
				LoadCurrentTrade ();
				break;
			}
		case "selling":
			if (Sc == 1) {
				
				int am = int.Parse (AmountText.text);
				if (_GM.get_CargoChoice () == 1) {
					
					Debug.Log ("hold = " + Hold.text);
					if (Hold.text == "Overloaded") {
						Debug.Log ("Sell over " + _Ship.Hold.ToString ());
						Hold.text = _Ship.Hold.ToString ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.General = 0;
						H_Generals.text = _Ship.General.ToString();
						LoadCurrentTrade ();
					} 
					else {
						Debug.Log ("normal " + _Ship.Hold.ToString ());
						_Ship.Hold += am;
						Hold.text = _Ship.Hold.ToString ();
						_Player.Cash += am * _Trade.get_General ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.General -= am;
						H_Generals.text = _Ship.General.ToString();
						LoadCurrentTrade ();
					}


				}
				else if(_GM.get_CargoChoice () == 2){

					if (Hold.text == "Overloaded") {

						Hold.text = _Ship.Hold.ToString ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.Arms = 0;
						H_Arms.text = _Ship.Arms.ToString();
						LoadCurrentTrade ();
					} 
					else {

						_Ship.Hold += am;
						Hold.text = _Ship.Hold.ToString ();
						_Player.Cash += am * _Trade.get_Arms ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.Arms -= am;
						H_Arms.text = _Ship.Arms.ToString();
						LoadCurrentTrade ();
					}
				}
				else if(_GM.get_CargoChoice () == 3){

					if (Hold.text == "Overloaded") {

						Hold.text = _Ship.Hold.ToString ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.Silk = 0;
						H_Silk.text = _Ship.Silk.ToString();
						LoadCurrentTrade ();
					} 
					else {

						_Ship.Hold += am;
						Hold.text = _Ship.Hold.ToString ();
						_Player.Cash += am * _Trade.get_Silk ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.Silk -= am;
						H_Silk.text = _Ship.Silk.ToString();
						LoadCurrentTrade ();
					}

				}
				else{
					
					if (Hold.text == "Overloaded") {

						Hold.text = _Ship.Hold.ToString ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.Opium = 0;
						H_Opium.text = _Ship.Opium.ToString();
						LoadCurrentTrade ();
					} 
					else {

						_Ship.Hold += am;
						Hold.text = _Ship.Hold.ToString ();_Player.Cash += am * _Trade.get_Opium ();
						Cash.text = _Player.Cash.ToString ();
						_Ship.Opium -= am;
						H_Opium.text = _Ship.Opium.ToString();
						LoadCurrentTrade ();

					}
				}

				break;
			}
			else {

				DisableBuySellButtonsButtons ();
				LoadCurrentTrade ();
				break;
			}
		
		default:
			Yes_Canvas.enabled = false;
			No_Canvas.enabled = false;
			break;
		}

	}
	public void Overloaded(string cargo, int am){

		Hold.text = "Overloaded";

		switch (cargo) {

		case "General":
			
			_Ship.General = am;
			H_Generals.text = am.ToString ();
			Cash.text = "0";
			LoadCurrentTrade ();
			break;
		case "Arms":

			_Ship.Arms = am;
			H_Arms.text = am.ToString ();
			Cash.text = "0";
			LoadCurrentTrade ();
			break;
		case "Silk":

			_Ship.Silk = am;
			H_Silk.text = am.ToString ();
			Cash.text = "0";
			LoadCurrentTrade ();
			break;
		case "Opium":

			_Ship.Opium = am;
			H_Opium.text = am.ToString ();
			Cash.text = "0";
			LoadCurrentTrade ();
			break;
		}


	}

	public void Normal_Trade(string cargo, int am){

		_Ship.Hold = _Ship.Hold - am;
		Hold.text = _Ship.Hold.ToString ();

		switch (cargo) {

		case "General":

			_Ship.General = am;
			H_Generals.text = _Ship.General.ToString ();
			_Player.Cash = _Player.Cash - ( am * _Trade.get_General());
			Cash.text = _Player.Cash.ToString ();
			LoadCurrentTrade ();
			break;
		case "Arms":
			
			_Ship.Arms = am;
			H_Arms.text = _Ship.Arms.ToString ();
			_Player.Cash = _Player.Cash - ( am * _Trade.get_Arms());
			Cash.text = _Player.Cash.ToString ();
			LoadCurrentTrade ();
			break;
		case "Silk":
			
			_Ship.Silk = am;
			H_Silk.text = _Ship.Silk.ToString ();
			_Player.Cash = _Player.Cash - ( am * _Trade.get_Silk());
			Cash.text = _Player.Cash.ToString ();
			LoadCurrentTrade ();
			break;
		case "Opium":
			
			_Ship.Opium = am;
			H_Opium.text = _Ship.Opium.ToString ();
			_Player.Cash = _Player.Cash - ( am * _Trade.get_Opium());
			Cash.text = _Player.Cash.ToString ();
			LoadCurrentTrade ();
			break;
		}
	}

	void NewPlace(string Place){

		_GM.set_GameState ("Trading");
		_Ship.Location = Place;
		Location.text = Place;
		Firm.text = FirmText + " " + _GM.get_PlayerName() + ", " + _Ship.Location;
		DisablePlaces_Buttons ();
		LoadTrade ();
	}







	public void Pressed_Yes(){

		SwitchScenes (1);
	}
	public void Pressed_No(){
		
		SwitchScenes (2);
	}
	public void Pressed_All(){

		if(_GM.get_GameState() == "MoneyLenderPayBack"){
			
			AmountText.text = _Player.Debt.ToString();
		}
		else if(_GM.get_GameState() == "bankdeposit")
		{ 
			AmountText.text = _Player.Cash.ToString();
		}
		else if(_GM.get_GameState() == "bankwithdraw"){ 
			
			AmountText.text = _Player.Bank.ToString();
		}
		else if(_GM.get_GameState() == "selling"){

			if (_GM.get_CargoChoice () == 1) {

				AmountText.text = _Ship.General.ToString();
			}
			else if(_GM.get_CargoChoice () == 2){

				AmountText.text = _Ship.Arms.ToString();
			}
			else if(_GM.get_CargoChoice () == 3){

				AmountText.text = _Ship.Silk.ToString();
			}
			else{
				
				AmountText.text = _Ship.Opium.ToString();
			}

		}
		else if(_GM.get_GameState() == "purchasing"){


			if (_GM.get_CargoChoice () == 1) {
				if (_Ship.Hold > PurchasePower) {
					
					BuyPower = PurchasePower;
					AmountText.text = BuyPower.ToString ();
				} 
				else {

					BuyPower = _Ship.Hold;
					AmountText.text = BuyPower.ToString ();
				}

			}
			else if(_GM.get_CargoChoice () == 2){
				if (_Ship.Hold > PurchasePower) {

					BuyPower = PurchasePower;
					AmountText.text = BuyPower.ToString ();
				} 
				else {

					BuyPower = _Ship.Hold;
					AmountText.text = BuyPower.ToString ();
				}
			}
			else if(_GM.get_CargoChoice () == 3){
				
				if (_Ship.Hold > PurchasePower) {

					BuyPower = PurchasePower;
					AmountText.text = BuyPower.ToString ();
				} 
				else {

					BuyPower = _Ship.Hold;
					AmountText.text = BuyPower.ToString ();
				}
			}
			else{

				if (_Ship.Hold > PurchasePower) {

					BuyPower = PurchasePower;
					AmountText.text = BuyPower.ToString ();
				} 
				else {

					BuyPower = _Ship.Hold;
					AmountText.text = BuyPower.ToString ();
				}
			}
		}
	}
	public void Pressed_None(){

		SwitchScenes (2);
	}
	public void Pressed_Del(){
		
		if (AmountText.text.Length > 0) {
			AmountText.text = AmountText.text.Substring(0, AmountText.text.Length -1);
		}

	}
	public void Pressed_Enter(){

		SwitchScenes (1);
	}
	public void Pressed_One(){

		AmountText.text += 1.ToString();
	}
	public void Pressed_Two(){

		AmountText.text += 2.ToString();
	}
	public void Pressed_Three(){

		AmountText.text += 3.ToString();
	}
	public void Pressed_Four(){

		AmountText.text+= 4.ToString();
	}
	public void Pressed_Five(){

		AmountText.text += 5.ToString();
	}
	public void Pressed_Six(){

		AmountText.text += 6.ToString();
	}
	public void Pressed_Seven(){

		AmountText.text += 7.ToString();
	}
	public void Pressed_Eight(){

		AmountText.text += 8.ToString();
	}
	public void Pressed_Nine(){

		AmountText.text += 9.ToString();
	}
	public void Pressed_Zero(){

		AmountText.text += 0.ToString();
	}



	public void Pressed_Buy(){
		
		_GM.set_GameState("buying");
		BuyScreen();
	}
	public void Pressed_Sell(){
		
		_GM.set_GameState ("selling");
		SellScreen();
	}
	public void Pressed_QuitTrading(){
		
		LoadPlaces_Buttons ();
	}
	public void Pressed_TransferCargo(){
		
		_GM.set_GameState ("transfercargo");
		LoadTransferScreen();
	}
	public void Pressed_VisitBank(){
		
		_GM.set_GameState ("bankdeposit");
		LoadVisitBankScreen();
	}
	public void Pressed_Opium(){
		_GM.set_CargoChoice (4);
		if (_GM.get_GameState () == "buying") {

			_GM.set_GameState ("purchasing");
			LoadPurchaseScreen(4);
		} 
		else {

			_GM.set_GameState ("selling");
			LoadSalesScreen(4);
		}
	}
	public void Pressed_Silk(){

		_GM.set_CargoChoice (3);
		if (_GM.get_GameState () == "buying") {

			_GM.set_GameState ("purchasing");
			LoadPurchaseScreen(3);
		} 
		else {

			_GM.set_GameState ("selling");
			LoadSalesScreen(3);
		}
	}
	public void Pressed_Arms(){

		_GM.set_CargoChoice (2);
		if (_GM.get_GameState () == "buying") {

			_GM.set_GameState ("purchasing");
			LoadPurchaseScreen(2);
		} 
		else {

			_GM.set_GameState ("selling");
			LoadSalesScreen(2);
		}
	}
	public void Pressed_General(){

		_GM.set_CargoChoice (1);
		if (_GM.get_GameState () == "buying") {

			_GM.set_GameState ("purchasing");
			LoadPurchaseScreen(1);
		} 
		else {

			_GM.set_GameState ("selling");
			LoadSalesScreen(1);
		}
	}
	public void Pressed_HongKong(){

		NewPlace ("Hong Kong");
	}
	public void Pressed_Shanghai(){

		NewPlace ("Shanghai");
	}
	public void Pressed_Nagasaki(){

		NewPlace ("Nagasaki");
	}
	public void Pressed_Saigon(){

		NewPlace ("Saigon");
	}
	public void Pressed_Manila(){

		NewPlace ("Manila");
	}
	public void Pressed_Singapore(){

		NewPlace ("Singapore");
	}
	public void Pressed_Batavia(){

		NewPlace ("Batavia");
	}
}
