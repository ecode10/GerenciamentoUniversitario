function mostraBtn(valor){
	document.all['td_btn_'+valor+'_2'].style.display = 'none';
	document.all['td_btn_'+valor+'_1'].style.display = '';
}
	
function escondeBtn(valor){
	document.all['td_btn_'+valor+'_2'].style.display = '';
	document.all['td_btn_'+valor+'_1'].style.display = 'none';
}
	
function desclick(campo){
	for(var i=0; i < document.all['TD_1'].length; i++){
		document.all['TD_1'][i].className = 'TDMenuInativo';
	}
	campo.className = 'TDMenuAtivo';
}

//Função para abrir páginas popup que já verifica se a altura e largura da página 
//ultrapassam o tamanho da tela e ajusta para o tamanho da tela e centraliza a
//página também.
//O "window.onunload = ..." verifica se já possui uma página filho aberta e fecha a tela popup
//ao sair da tela pois a popup é declarada com a varável "newWindow".
	
var newWindow;

window.onunload = function anonymous(){if (newWindow != undefined){newWindow.close();}}
	
function abrir(pagina, largura, altura, topo, esquerda){
	var iTamAltura = altura
	var iTamLargura = largura
	
	if (altura >= screen.availHeight){
		iTamAltura = screen.availHeight - 50;
	} 
		
	if (largura >= screen.availWidth){
		iTamLargura = screen.availWidth - 50;
	}
	
	var LeftPosition = (screen.availWidth) ? (screen.availWidth-iTamLargura)/2 : 0;
	var TopPosition = (screen.availHeight) ? (screen.availHeight-iTamAltura)/2-10 : 0;
	
	if (newWindow != undefined){
		newWindow.close();
	}
	
	newWindow = window.open(pagina,"","status=no,menubar=no,scrollbars=yes,toolbar=no,location=no,resizable=yes,width="+iTamLargura+"px, height="+iTamAltura+"px, left="+LeftPosition+", top="+TopPosition)
}

function abrir_3(pagina, largura, altura, topo, esquerda){
	var iTamAltura = altura
	var iTamLargura = largura
	
	if (altura >= screen.availHeight){
		iTamAltura = screen.availHeight - 50;
	} 
		
	if (largura >= screen.availWidth){
		iTamLargura = screen.availWidth - 50;
	}
	
	var LeftPosition = (screen.availWidth) ? (screen.availWidth-iTamLargura)/2 : 0;
	var TopPosition = (screen.availHeight) ? (screen.availHeight-iTamAltura)/2-10 : 0;
	
	window.open(pagina,"","status=no,menubar=no,scrollbars=yes,toolbar=no,location=no,resizable=yes,width="+iTamLargura+"px, height="+iTamAltura+"px, left="+LeftPosition+", top="+TopPosition)
}

function w_ModalAcao(pagina, oValores){
	showModalDialog(pagina,'',"dialogWidth:200px;dialogHeight:150px;status:no;center:on;help:no;resizable:no");
}

function abrir_2(pagina, largura, altura, topo, esquerda){
	var iTamAltura = altura
	var iTamLargura = largura
	
	if (altura >= screen.availHeight){
		iTamAltura = screen.availHeight - 50;
	} 
		
	if (largura >= screen.availWidth){
		iTamLargura = screen.availWidth - 50;
	}
	
	var LeftPosition = (screen.availWidth) ? (screen.availWidth-iTamLargura)/2 : 0;
	var TopPosition = (screen.availHeight) ? (screen.availHeight-iTamAltura)/2-10 : 0;
	
	if (newWindow != undefined){
		newWindow.close();
	}
		
	newWindow = window.open(pagina,"","status=no,menubar=no,scrollbars=no,toolbar=no,location=no,resizable=no,width="+iTamLargura+"px, height="+iTamAltura+"px, left="+LeftPosition+", top="+TopPosition)
}

function abrirDocumento(pagina, largura, altura, topo, esquerda){
	var iTamAltura = altura
	var iTamLargura = largura
	
	if (altura >= screen.availHeight){
		iTamAltura = screen.availHeight - 50;
	} 
		
	if (largura >= screen.availWidth){
		iTamLargura = screen.availWidth - 50;
	}
	
	var LeftPosition = (screen.availWidth) ? (screen.availWidth-iTamLargura)/2 : 0;
	var TopPosition = (screen.availHeight) ? (screen.availHeight-iTamAltura)/2-10 : 0;
	
	if (newWindow != undefined){
		newWindow.close();
	}
	
	newWindow = window.open(pagina,"FMNovo","status=no,menubar=no,scrollbars=yes,toolbar=no,location=no,resizable=yes,width="+iTamLargura+"px, height="+iTamAltura+"px, left="+LeftPosition+", top="+TopPosition)
}

//Objetivo: Validar o Formulário com exceção dos campos definidos pelo programador.
//Sintaxe: f_ValidaForm(sNomeForm, sMsgObrigatorio, NomeCampo1, NomeCampo2, NomeCampo3...)
//sNomeForm = nome do formulário, passado como uma string. Ex: "form1"
//sMsgObrigatorio = mensagem enviada para o usuário de campo obrigatório. Ex: "Campo Obrigatório!"
//NomeCampo1...NomeCampoN = nome dos campos não validados, pode conter quantos campos necessário, o nome do campo
//							é passado como uma string. Ex: "txtNome"
//Exemplo Real: s_ValidaForm("form1", "Os campos com * são obrigatórios", "txtNome")
//Descrição do Exemplo Real:
//	será validado o formulário "form1", exibindo a mensagem "Os campos com * são obrigatórios" para o campo obrigatório
//	não preenchido. todos os campos do formulário serão validados com exceção do campo de nome "txtNome"

//oForm = document.form1;
//var bValidaForm = s_ValidaForm("form1", "Preencha os Campos Obrigatórios") 
//if (bValidaForm == true){ 
//oForm.PrmAcao.value = "InserirTipoRotina"; oForm.submit();
//} 


function f_ValidaForm(sNomeForm, sMsgObrigatorio){
	oForm = eval("document."+ sNomeForm);
	for (var i = 0; i < oForm.length; i++){
		var bEParaValidar = true;
		for (var j = 0; j < f_ValidaForm.arguments.length; j++){
			var sNomeNaoValidar = f_ValidaForm.arguments[j];
			if (sNomeNaoValidar == oForm[i].name){
				bEParaValidar = false;
			}
		}
		if (bEParaValidar == true){
			if (oForm[i].type == "text" || 
					oForm[i].type == "textarea" ||
						oForm[i].type == "password" ||
							oForm[i].type == "file" ||
								oForm[i].type == "select-one" ||
									oForm[i].type == "select-multiple"){
				var sValor = f_eVazio(oForm[i].value)
				if (sValor == true){
					alert(sMsgObrigatorio);
					oForm[i].value = "";
					oForm[i].focus();
					return false;
				}
			}
			if (oForm[i].type == "radio" || oForm[i].type == "checkbox"){
				var sNome = oForm[i].name;
				var bTodosDesmarcados = true;
				for (var k = 0; k < oForm.length; k++){
					if (oForm[k].type == "radio" && oForm[k].name == sNome){
						if (oForm[k].checked == true){
							bTodosDesmarcados = false;
						}
					}
					if (oForm[k].type == "checkbox" && oForm[k].name == sNome){
						if (oForm[k].checked == true){
							bTodosDesmarcados = false;
						}
					}							
				}
								
				if (bTodosDesmarcados == true){
					alert(sMsgObrigatorio);
					oForm[i].value = "";
					oForm[i].focus();
					return false;						
				}
			}	
		}
	}
	return true;
}


//Verifica se o valor passado é vazio, ou só tem espaço
function f_eVazio(sString){
	var regEspaco = /\s/g;
	sString = sString.replace(regEspaco, "");
	if (sString == ""){
		return true;
	} else {
		return false;
	}
}  


//Permite somente caracteres numéricos
//Ex: onKeyPress="f_bSoNumero(event.keyCode)"
// Autor: Adriano Pamplona
function f_bSoNumero(keyCodigo){
	if (keyCodigo!=null){
		if ((keyCodigo >= 48 && keyCodigo <= 57)){return true;}
		else {event.keyCode = 0;}
	}			
}


// Para usar voce passa a tecla e o nome do form
// exemplo: onkeypress('event.keyCode', 'nome do seu form')
function f_bEnter(vTecla, sNoForm){
	// Executa Enter no Form.
	if (vTecla == 13){
		eval("document."+sNoForm+".submit()");
	}
}




function s_HabilitarBtn(sNoChk, sNoTxt, form)
{		
	var iCountAlterar = 0;
	var objChk = eval("document.all['"+sNoChk+"']");
	var sForm = eval("document."+form);
	var objTxt = eval("document."+form+"."+sNoTxt);
		
	if(objChk.length == undefined){
		if (objChk.checked == true){
			if (sForm.btnAlterar != undefined){
				sForm.btnAlterar.disabled = false;
			}
			if (sForm.btnExcluir != undefined){	
				sForm.btnExcluir.disabled = false; 
			}	
			objTxt.value = objChk.value;  
		}else{
			if (sForm.btnAlterar != undefined){
				sForm.btnAlterar.disabled = true;
			}	
			if (sForm.btnExcluir != undefined){
				sForm.btnExcluir.disabled = true;
			}	
			objTxt.value = '';  
		}
	}else{
		for (var i=0; i< objChk.length; i++){
			if (objChk[i].checked == true){
				iCountAlterar = iCountAlterar + 1;
				objTxt.value = '';
				objTxt.value = objChk[i].value;  
			}
		}
					
		if (sForm.btnExcluir != undefined){
			if (iCountAlterar >= 1){
				sForm.btnExcluir.disabled = false;  
			}else{
				sForm.btnExcluir.disabled = true;
			} 
		}
		if (sForm.btnAlterar != undefined){			
			if (iCountAlterar == 1){
				sForm.btnAlterar.disabled = false;  
			}else{
				sForm.btnAlterar.disabled = true;  
			}
		}	
	}
}



//
// Transforma um valor em um real calculável pelo JavaScript
// ex: 1.045,33 retorna 1045.33
// funções utilizadas: f_sColocaString
// Autor: Adriano Pamplona
function f_sPassaFloat(valor){
	var bPonto = /\./g;
	var bVirgu = /\,/g;
	var contVirgu = 0;
	var contPonto = 0;
	var letra = "";
	if (valor==""){valor = "0";}
	valor = valor.toString();
	if (valor.indexOf(",")!=-1){
		valor = valor.replace(bPonto,"");
		for (var i = 0; i < valor.length; i++){
			letra = valor.charAt(i);
			if (letra == ","){contVirgu = contVirgu + 1;}
		}
		if (contVirgu <= 1){
			valor = valor.replace(",",".");}
		else {
			valor = valor.replace(bVirgu,"");
			valor = f_sColocaString(valor,".",2);
		}
	} else {
		if (valor.indexOf(".")!=-1){
			for (var i = 0; i < valor.length; i++){
				letra = valor.charAt(i);
				if (letra == "."){contPonto = contPonto + 1;}
			}
			if (contPonto > 1){
				valor = valor.replace(bPonto,"");}
		}
	}
	valor = parseFloat(valor);
	return valor;
}	
			
//
// Formata um valor para impressão em tela
// ex 10045.34 retorna 10.045,34
// funções utilizadas: f_sPassaFloat
// Autor: Adriano Pamplona
function f_sFormataNum(valor){
	var vMilhar, vAux, vDivMil, vDec;
	vAux = "";
	vDivMil = 1;
	valor = f_sPassaFloat(valor);
	valor = valor.toString();
	if (valor.indexOf(".")==-1){
		vMilhar = valor.length;
		vDec		= "00";}
	else {
		vMilhar = valor.indexOf(".");
		vDec		= valor.substr(vMilhar+1,2);
		if (vDec.length==1){vDec = vDec+"0";}
	}
	vMilhar = valor.substr(0,vMilhar);
	if (vMilhar.length>3){
		for (var i = vMilhar.length-1; i >=0; i--){
			vAux = vMilhar.charAt(i) + vAux;
			if (vDivMil==3){
				vAux = "." + vAux;
				vDivMil = 0;
			}
			vDivMil = vDivMil + 1;
		}
		if (vAux.charAt(0)=="-"){
			if (vAux.charAt(1)=="."){
				vAux =  "-" + vAux.substr(2,vAux.length);
			}
		}
		if (vAux.charAt(0)=="."){
			vAux =  vAux.substr(1,vAux.length);
		}
	} else {
		vAux = vMilhar;}
	valor = vAux + "," + vDec;
	return valor;							
}

//
// insere um caracter onde quer que queira.
// parametros: string com o valor , caracter a ser inserido, index da string a ser inserida.
// o index da string é da direita para a esquerda
// ex: f_sColocaString("xxx",".",2) retorna x.xx
// Autor: Adriano Pamplona
//
function f_sColocaString(vSt,vChar,vCasa){
	var vStRetorno = "";
	if (vSt.indexOf(",")!=-1){
		vBusVir = /\,/g;
		vSt = vSt.replace(vBusVir,"");}
	for (var i = 0; i < vSt.length; i++){
		if (i == (vSt.length - parseInt(vCasa, 10))){
			vStRetorno = vStRetorno + vChar ;}
		vStRetorno = vStRetorno + vSt.charAt(i);
	}
	return vStRetorno;
}


//
// mascara de valores inteiros
// o parâmetro passado tem que ser o código da tecla
// ex:  onKeyPress="f_sMascaraInteiro(event.keyCode,null);" onKeyUp="f_sMascaraInteiro(null,this);"
// Autor: Adriano Pamplona
//
function f_sMascaraInteiro(keyCodigo,obj){
	if (keyCodigo!=null){
		if ((keyCodigo >= 48 && keyCodigo <= 57)){return true;}
		else {event.keyCode = 0;}
	}
	if (obj!=null){
		var vRetorno = "";
		vValor = obj.value;
		switch (vValor.length){
			case 0:
				vRetorno = "0";
				break;
			default:
				if (vValor.length >= 4){
					var bPonto = /\./g;
					var vValorTemp = vValor
					var vValorTemp = vValorTemp.replace(bPonto,"");
					var vRet = "";
					cont = 0;
					for (var i = vValorTemp.length; i >= 0; i--){
						vRet = vValorTemp.charAt(i) + vRet;
						if (cont == 3){
							vRet = "." + vRet;;
							cont = 0;
						}
						cont ++;
					}
					while (vRet.charAt(0)=="." || vRet.charAt(0)=="0"){
						vRet = vRet.substr(1,vRet.length)
					}
					vValor = vRet;
				}
				vRetorno = vValor;
		}
		obj.value = vRetorno;}
}
			
			
//
// mascara o valores reais.
// ex: onKeyPress="f_sMascaraReal(event.keyCode,null);" onKeyUp="f_sMascaraReal(null,this);"
// funções utilizadas: f_sMascaraInteiro
// Autor: Adriano Pamplona
//
function f_sMascaraReal(keyCodigo,obj){
	if (keyCodigo!=null){
		f_sMascaraInteiro(keyCodigo,null);
	}
	if (obj!=null){
		var vRetorno = "";
		var vValores = "";
		vValor = obj.value;
		vValor = vValor.replace(",","");
		vValores = vValor.split(".");
		
		vValor = vValores.join("");		
		vValor = vValor.substr(0,10);
		
		switch (vValor.length){				
			case 1:
				vRetorno = "0,0"+vValor;				
				break;				
			case 2:
				vRetorno = "0,"+vValor;
				break;
			default:
				vValor = vValor.replace(",","");
				vValor = vValor.replace(".","");
				vValor = f_sColocaString(vValor,",",2);
				if (vValor.charAt(0)==0){vValor = vValor.substr(1,vValor.length);}
				if (vValor.charAt(0)==","){vValor = vValor.substr(1,vValor.length);}
				if (vValor.length==2){vValor = "0,"+vValor;}
							
				if (vValor.length > 11){
					var bPonto = /\./g;
					var vValorTemp = vValor.substr(0,vValor.indexOf(","))
					var vValorTemp = vValorTemp.replace(bPonto,"");
					var vRet = "";
					cont = 0;
					for (var i = vValorTemp.length; i >= 0; i--){
						vRet = vValorTemp.charAt(i) + vRet;
						if (cont == 3){
							vRet = "." + vRet;
							cont = 0;
						}
						cont ++;
					}
					while (vRet.charAt(0)=="." || vRet.charAt(0)=="0"){
						vRet = vRet.substr(1,vRet.length);
					}
					vValor = vRet + vValor.substr(vValor.indexOf(","),vValor.length);						
				}
				vRetorno = vValor;
		}
			
		if (vRetorno == "0,00")
		{	
			vRetorno = "";
		}
		obj.value = vRetorno;
	}
}

			
//
// mascara a data.
// ex:  onKeyPress="f_sMascaraData(event.keyCode,null);" 
// ex:  onKeyUp="f_sMascaraData(null,this);"
// funções utilizadas: f_sMascaraInteiro
// Autor: Adriano Pamplona
//
function f_sMascaraData(keyCodigo,obj){
	if (keyCodigo!=null){
		f_sMascaraInteiro(keyCodigo,null);
		return;
	}
	if (obj != null){
		vValor = obj.value;
	}
	if (vValor.length >= 10){
		event.keyCode = 0;
	}else{
		if (obj!=null){
			var vRetorno = "";
			if (window.event.keyCode == 8){
				if (vValor.length==2 || vValor.length==5){
					vValor = vValor.substr(0,vValor.length-1);
					obj.value = vValor;
				}
			}
			switch (vValor.length){
				case 2:
					vRetorno = vValor + "/";
					break;
				case 5:
					vRetorno = vValor + "/";
					break;
				default:
					if (vValor.length >= 10){
						vDia = vValor.substr(0,2);
						vMes = vValor.substr(3,2);
						vAno = vValor.substr(6,4);
						vRetorno = vDia +"/"+ vMes +"/"+ vAno;
					} else { 
						vRetorno = vValor;
					}
			}
			obj.value = vRetorno;
		}
	}
}

//
// mascara hora.
// ex:  onKeyPress="f_sMascaraHora(event.keyCode,null);" 
// ex:  onKeyUp="f_sMascaraHora(null,this);"
// funções utilizadas: f_sMascaraInteiro
// Autor: Regis Salomão
//
function f_sMascaraHora(keyCodigo,obj){
	if (keyCodigo!=null){
		f_sMascaraInteiro(keyCodigo,null);
		return;
	}
	if (obj != null){
		vValor = obj.value;
	}
	if (vValor.length >= 5){
		event.keyCode = 0;
	}else{
		if (obj!=null){
			var vRetorno = "";
			if (window.event.keyCode == 8){
				if (vValor.length==2){
					vValor = vValor.substr(0,vValor.length-1);
					obj.value = vValor;
				}
			}
			switch (vValor.length){
				case 2:
					vRetorno = vValor + ":";
					break;
				default:
					if (vValor.length >= 5){
						var vHor = vValor.substr(0,2);
						var vMin = vValor.substr(3,2);						
						vRetorno = vHor +":"+ vMin;
					} else { 
						vRetorno = vValor;
					}									
			}
			obj.value = vRetorno;
		}
	}
}

function f_sMascaraHora2(keyCodigo,obj){
	
	var bPontoVirugula = /\:/g;
	if (keyCodigo!=null){
		f_sMascaraInteiro(keyCodigo,null);
		return;
	}
	if (obj.value != ''){
	
		if (obj != null){
			vValor = obj.value;
		}
		
		if (vValor.length > 7){
			obj.value = vValor.substr(0,vValor.length-1)
		}
			
		if (vValor.length >= 3){		
			vValor = vValor.replace(bPontoVirugula,"");		
			vValor = vValor.substr(0,vValor.length-2) + ":" +  vValor.substr(vValor.length-2,2)
			obj.value = vValor;	
		}
			
		if (vValor.length == 3){
			obj.value = vValor.replace(bPontoVirugula,"");
		}
	}	
}

//
// validação de quantidade de horas.
// se data válida passa o objeto, caso contrário volta ao objeto.
// ex: onBlur="s_ValidaHora(this);"
// obj: use em conjunto com a função f_sMascaraHora
// Autor: Regis Salomão
//
function s_ValidaHora(obj){
	var vRetorno = true;
	var vHor, vMin;
	vValor = obj.value;

	if (vValor.length==0){return true;}
	if (vValor.length!=5 && vValor.length>0){vRetorno = false;}
	
	if (vValor.charAt(2) != ":"){
		vRetorno = false;
	}
	vHor = vValor.substr(0,2);
	vHor = parseInt(vHor, 10);
	vMin = vValor.substr(3,2);
	vMin = parseInt(vMin, 10);
	
	if (vHor > 23){
		vRetorno = false;
	}
				
	if (vMin > 59) {
		vRetorno = false;
	}
				
	if (vRetorno==false){
		alert("Hora Inválida.");
		obj.focus();
		obj.select();
		return false;
	}
	return true;	
}

//
// validação de quantidade de horas.
// se data válida passa o objeto, caso contrário volta ao objeto.
// ex: onBlur="s_ValidaQtdHora(this);"
// obj: use em conjunto com a função f_sMascaraHora
// Autor: Regis Salomão
//
function s_ValidaQtdHora(obj){
	var vRetorno = true;
	var vHor, vMin;
	vValor = obj.value;

	if (vValor.length==0){return true;}
	if (vValor.length!=5 && vValor.length>0){vRetorno = false;}
	
	if (vValor.charAt(2) != ":"){
		vRetorno = false;
	}
	
	vMin = vValor.substr(3,2);
	vMin = parseInt(vMin, 10);
				
	if (vMin > 59) {
		vRetorno = false;
	}
	
	if (obj.value == '00:00'){
		vRetorno = false;
	}			
	if (vRetorno==false){
		alert("Hora Inválida.");
		obj.focus();
		obj.select();
		return false;
	}
	return true;	
}

//
// validação de quantidade de horas.
// se data válida passa o objeto, caso contrário volta ao objeto.
// ex: onBlur="s_ValidaQtdHora2(this);"
// obj: use em conjunto com a função f_sMascaraHora
// Autor: Regis Salomão
//
function s_ValidaQtdHora2(obj){
	var vRetorno = true;
	var vHor, vMin;
	vValor = obj.value;

	if (vValor.length==0){return true;}
	if (vValor.length<3 && vValor.length>0){vRetorno = false;}
	
	/*if (vValor.charAt(2) != ":"){
		vRetorno = false;
	}*/
	
	vMin = vValor.substr(vValor.length-2,2);
	vMin = parseInt(vMin, 10);
				
	if (vMin > 59) {
		vRetorno = false;
	}
	
	if (obj.value == '00:00'){
		vRetorno = false;
	}			
	if (vRetorno==false){
		alert("Hora Inválida.");
		obj.focus();
		obj.select();
		return false;
	}
	return true;	
}

//
//Valida CEP
//ex:   onBlur="f_bValidaCEP(this)"
//autor: Regis Salomão
//
function f_bValidaCEP(oObj){
	if (oObj.value != ''){
		if (oObj.value.length != 10){
			alert('CEP inválido');
			oObj.focus();
			return;
		}
	}	
}

//
// mascara CEP
// ex:  onKeyPress="f_sMascaraCEP(event.keyCode,null);" onKeyUp="f_sMascaraCEP(null,this);"
// funções utilizadas: f_sMascaraInteiro
// Autor: Regis Salomão
//
function f_sMascaraCEP(keyCodigo,obj){
	if (keyCodigo!=null){
		f_sMascaraInteiro(keyCodigo,null);
		return;
	}
	if (obj != null){
		vValor = obj.value;
	}
	if (vValor.length >= 10){
		event.keyCode = 0;
	}else{
		if (obj!=null){
			var vRetorno = "";
			
			if (window.event.keyCode == 8){
				if (vValor.length==2 || vValor.length==6){
					vValor = vValor.substr(0,vValor.length-1);
					obj.value = vValor;
				}
			}
			switch (vValor.length){
				case 2:
					vRetorno = vValor + ".";
					break;
				case 6:
					vRetorno = vValor + "-";
					break;
				default:
					if (vValor.length >= 10){
						vRetorno = vValor.substr(0,2) +"."+ vValor.substr(3,3) +"-"+ vValor.substr(6,3);
					} else { 
						vRetorno = vValor;
					}
			}
			obj.value = vRetorno;
		}
	}
}

//
// mascara CPF
// ex:  onKeyPress="f_sMascaraCPF(event.keyCode,null);" onKeyUp="f_sMascaraCPF(null,this);"
// funções utilizadas: f_sMascaraInteiro
// Autor: Regis Salomão
//
function f_sMascaraCPF(keyCodigo, obj) {
    if (keyCodigo != null) {
        f_sMascaraInteiro(keyCodigo, null);
        return;
    }
    if (obj != null) {
        vValor = obj.value;
    }
    if (vValor.length >= 12) {
        event.keyCode = 0;
    } else {
        if (obj != null) {
            var vRetorno = "";

            if (window.event.keyCode == 8) {
                if (vValor.length == 2 || vValor.length == 6) {
                    vValor = vValor.substr(0, vValor.length - 1);
                    obj.value = vValor;
                }
            }
            switch (vValor.length) {
                case 3:
                    vRetorno = vValor + ".";
                    break;
                case 7:
                    vRetorno = vValor + ".";
                    break;
                case 11:
                    vRetorno = vValor + "-";
                    break;
                default:
                    if (vValor.length >= 11) {
                        vRetorno = vValor.substr(0, 2) + "." + vValor.substr(3, 3) + "-" + vValor.substr(6, 3);
                    } else {
                        vRetorno = vValor;
                    }
            }
            obj.value = vRetorno;
        }
    }
}



//
//Macara e Valida Telefone
//ex:   onBlur="f_sValMasTel(this)"
//autor: Regis Salomão
//
function f_sValMasTel(oObj){
	if (oObj.value != ''){
		if (oObj.value.length == 7){
			oObj.value = f_sColocaString(oObj.value,"-",4);
		}else if (oObj.value.length == 8){
			oObj.value = f_sColocaString(oObj.value,"-",4);
		} else if (oObj.value.length == 10) {
		    oObj.value = f_sColocaString(oObj.value, "-", 4);
		    oObj.value = f_sColocaString(oObj.value, "-", 9);
		} else if (oObj.value.length == 9) {
		    alert('Telefone invalido.');
		    //oObj.focus();
		    return;
		} else if (oObj.value.length > 11) {
		    alert('Telefone invalido.');
		    //oObj.focus();
		    return;
		}
		
	}	
}

function f_bValidaEmail(oObj){
	var iArroba = 0;
	if (oObj.value != ''){
		for (var i = 0; i <= oObj.value.length-1;i++){
			if (oObj.value.substr(i,1) == '@'){
				iArroba = 1;
			}
		}
		if (iArroba == 0){
			alert('Email inválido.');
			oObj.focus();
			return;
		}
	}	
}	

//Efetua a transferência de options entre 2 selects
//Ex:
// botão >> = onClick="s_SelectMultiplo(document.form1.cboOrigem, document.form1.cboDestino, true);"
// botão << = onClick="s_SelectMultiplo(document.form1.cboDestino, document.form1.cboOrigem, true);"
//Parâmetros: objeto de origem, objeto de destino, ordena listagem
//Autor: Adriano Pamplona
function s_SelectMultiplo(oOrigem, oDestino, bOrdena){
	var sListagemDestino	= "";
	var oOption				= "";
	var sValoresDoOrigem	= "";
	var sValoresDoDestino	= "";
	var sSubValorOrigem		= "";
	var sSubValorDestino	= "";
	var sValor				= "";
	var sTexto				= "";
	var bTemSelecionado		= false;
	for (var i = 0; i < oDestino.options.length; i++){
		sListagemDestino += "§"+ oDestino.options[i].text+"22";
	}
	for (var i = (oOrigem.options.length - 1); i >= 0 ; i--){
		if (oOrigem.options[i].selected == true && sListagemDestino.indexOf(oOrigem.options[i].text + "22") == -1){
			bTemSelecionado = true;
			sValoresDoOrigem += oOrigem.options[i].text +"="+ oOrigem.options[i].value +"§§"
			oOrigem.remove(i);
		}
	}

	if (bTemSelecionado == false){return;}
			
	sValoresDoOrigem = sValoresDoOrigem.substr(0, sValoresDoOrigem.length - 2);
	sValoresDoOrigem = sValoresDoOrigem.split("§§");
	for (var i = 0; i < sValoresDoOrigem.length; i++){
		sSubValorOrigem = sValoresDoOrigem[i];
		sSubValorOrigem = sSubValorOrigem.split("=");
		sTexto = sSubValorOrigem[0];
		sValor = sSubValorOrigem[1];
		oOption = new Option(sTexto, sValor);
		oDestino.options[oDestino.options.length] = oOption;
	}
			
	if (bOrdena == true){
		for (var i = (oDestino.options.length - 1); i >= 0 ; i--){
			sValoresDoDestino += oDestino.options[i].text +"="+ oDestino.options[i].value +"§§"
			oDestino.remove(i);
		}
		sValoresDoDestino = sValoresDoDestino.substr(0, sValoresDoDestino.length - 2);
		sValoresDoDestino = sValoresDoDestino.split("§§");				
		sValoresDoDestino.sort();
		for (var i = 0; i < sValoresDoDestino.length; i++){
			sSubValorDestino = sValoresDoDestino[i];
			sSubValorDestino = sSubValorDestino.split("=");
			sTexto = sSubValorDestino[0];
			sValor = sSubValorDestino[1];
			oOption = new Option(sTexto, sValor);
			oDestino.options[oDestino.options.length] = oOption;
		}				
	}
	if (oOrigem.options[0]){
		oOrigem.options[0].selected = true;
	}
	return;
}

function s_Visualizar(caminho){
	abrirDocumento(caminho,'630','500','130','100');
}

/*
Nome: mascara_money
Utilização: mascarar valores numéricos com 2 casas decimais seguindo 
			o padrão monetário brasileiro (ex: 1.250,45)
Desenvolvida por: Antônio Benedito
Data: 20/01/2002
Alterado por:
Data Alteração:
Modo de usar: coloca-se no campo text (html) conforme linha abaixo
			  onkeyup = "mascara_money(this);"
*/
function mascara_money(objeto){
	valor = objeto.value;
	mascara = "[###.]###,##";
	var mascara_utilizar;
	var mascara_limpa;
	var temp;
	var i;
	var j;
	var caracter;
	var separador;
	var dif;
	var validar;
	var mult;
	var ret;
	var tam;
	var tvalor;
	var valorm;
	var masct;
	tvalor = "";
	ret = "";
	caracter = "#";
	separador = "|";
	mascara_utilizar = "";
	valor = trim(valor);
	if (valor == "")objeto.value= valor;
	temp = mascara.split(separador);
	dif = 1000;
	
	valorm = valor;
	//tirando mascara do valor já existente
	for (i=0;i<valor.length;i++){
		if (!isNaN(valor.substr(i,1))){
			tvalor = tvalor + valor.substr(i,1);
		}
	}
	valor = tvalor;
	for (i=0;i<valor.length;i++){
		if (isNaN(valor.substr(i,1))){
			tvalor = tvalor + valor.substr(i,1);
		}
	}
		valor = tvalor;
	//formatar mascara dinamica
	for (i = 0; i<temp.length;i++){
		mult = "";
		validar = 0;
		for (j=0;j<temp[i].length;j++){
			if (temp[i].substr(j,1) == "]"){
				temp[i] = temp[i].substr(j+1);
				break;
			}
			if (validar == 1)mult = mult + temp[i].substr(j,1);
			if (temp[i].substr(j,1) == "[")validar = 1;
		}
		for (j=0;j<valor.length;j++){
			temp[i] = mult + temp[i];
		}
	}
	
	
	//verificar qual mascara utilizar
	if (temp.length == 1){
		mascara_utilizar = temp[0];
		mascara_limpa = "";
		for (j=0;j<mascara_utilizar.length;j++){
			if (mascara_utilizar.substr(j,1) == caracter){
				mascara_limpa = mascara_limpa + caracter;
			}
		}
		tam = mascara_limpa.length;
	}else{
		//limpar caracteres diferente do caracter da máscara
		for (i=0;i<temp.length;i++){
			mascara_limpa = "";
			for (j=0;j<temp[i].length;j++){
				if (temp[i].substr(j,1) == caracter){
					mascara_limpa = mascara_limpa + caracter;
				}
			}
			
			if (valor.length > mascara_limpa.length){
				if (dif > (valor.length - mascara_limpa.length)){
					dif = valor.length - mascara_limpa.length;
					mascara_utilizar = temp[i];
					tam = mascara_limpa.length;
				}
			}else if (valor.length < mascara_limpa.length){
				if (dif > (mascara_limpa.length - valor.length)){
					dif = mascara_limpa.length - valor.length;
					mascara_utilizar = temp[i];
					tam = mascara_limpa.length;
				}
			}else{
				mascara_utilizar = temp[i];
				tam = mascara_limpa.length;
				break;
			}
		}
	}
	
	//validar tamanho da mascara de acordo com o tamanho do valor
	if (valor.length > tam){
		valor = valor.substr(0,tam);
	}else if (valor.length < tam){
		masct = "";
		j = valor.length;
		for (i = mascara_utilizar.length-1;i>=0;i--){
			if (j == 0) break;
			if (mascara_utilizar.substr(i,1) == caracter){
				j--;
			}
			masct = mascara_utilizar.substr(i,1) + masct;
		}
		mascara_utilizar = masct;
	}
	
	//mascarar
	j = mascara_utilizar.length -1;
	for (i = valor.length - 1;i>=0;i--){
		if (mascara_utilizar.substr(j,1) != caracter){
			ret = mascara_utilizar.substr(j,1) + ret;
			j--;
		}
		ret = valor.substr(i,1) + ret;
		j--;
	}
	objeto.value = ret;
}

//tirar os espaços das extremidades do valor passado
function trim(valor){
	for (i=0;i<valor.length;i++){
		if(valor.substr(i,1) != " "){
			valor = valor.substr(i);
			break;
		}
		if (i == valor.length-1){
			valor = "";
		}
	}
	for (i=valor.length-1;i>=0;i--){
		if(valor.substr(i,1) != " "){
			valor = valor.substr(0,i+1);
			break;
		}
	}
	return valor;
}

//----------------------------------------------------------------------------------
//Função: f_swapKeyEnter4BR
//----------------------------------------------------------------------------------
//Objetivo:		Trocar o código da tecla enter pela tag <br>
//Indicação:	Sempre que for imprimir texto gravado no banco no corpo de texto de
//				uma página HTML.
//----------------------------------------------------------------------------------
function f_swapKeyEnter4BR(sValor)
{
	var kEnter = new RegExp()
	kEnter.compile("\n","g");
	return(sValor.replace(kEnter,"<br>"));
}

/*
Função..........: sDivRedim
Objetivos.......: Redimensiona dinâmicamente uma div de acordo com o tamanho
                  da janela.
Parâmetros......:
  idIdv.........: Objeto Div que deve ser redimensionado
  iAlturaMinima.: AlturaMinima que a Div pode assumir
  iDesvio.......: Altura do conteúdo exibido após a Div. Pode ser extraído
                  da propriedade offSetHeight em vários objetos.
Eventos.........: <body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0">onload
                  <body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0">onresize
*/
function s_DivRedim(idDiv,iAlturaMinima,iDesvio)
{
	var iTotal=0;
	var iMax=document.body.offsetHeight-iDesvio;
	var iParcial=0;
	var iAlturaDiv = idDiv.offsetHeight;
	var iPosTopDiv = idDiv.offsetTop;
	iTotal = iPosTopDiv + iAlturaDiv;
	if (iTotal>iMax)
	{
		idDiv.style.height = iAlturaMinima;
	}
	else
	{
		idDiv.style.height = iAlturaDiv+(iMax - iTotal);
	}
}

function s_Enter(KeyCode){
	if (KeyCode == 13){
		if (document.forms[0].btnPesquisar){
			document.forms[0].btnPesquisar.onclick();
		}
		
		if (document.forms[0].btPesquisar){
			document.forms[0].btPesquisar.onclick();
		}
	}	
}

//Desenvolvedor: Regis Salomão
//Data: 03/06/2004
//Função para calcular o esforco de alteração para esc.
//Caso a esc tenha sofrido uma alteração, a estimativa será feita somente para as alterações.
//Legenda:
	//HrFxAnt	- Horas da Faixa anterior
	//PtAlt		- Pontuação da Alteração
	//LimMaxFx	- Limite Máx. de pontos na faixa
	//LimMinFx	- Limite Min. de pontos na faixa
	//HrFx		- Horas da Faixa
function f_dCalculaEsforcoAlteracao(HrFxAnt, PtAlt, LimMaxFx, LimMinFx, HrFx){
	var dEsforcoTotal = 0;
	dEsforcoTotal = HrFxAnt + (((PtAlt - LimMinFx)/(LimMaxFx - LimMinFx)) * (HrFxAnt/HrFx)* HrFx)
	return dEsforcoTotal;	
}


function tecla(){
	var letra=String.fromCharCode(window.event.keyCode);
	var cadeia = " 1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúãõâêîôûç!@#$%ü&*-+=?:;,.ªº|";
	var posicao = cadeia.indexOf(letra);
	if((window.event.keyCode==92)||(window.event.keyCode==9)){
	    posicao = 1;
	} 
	if(posicao==-1){
	    window.event.keyCode = 0;
	    window.event.returnValue = false;
	}         
}

// validação de data.
// se data válida passa o objeto, caso contrário volta ao objeto.
// ex: onBlur="f_bValidaData(this);"
// obj: use em conjunto com a função f_sMascaraData
// Autor: Adriano Pamplona
//
function f_bValidaData(obj){
	var vRetorno = true;
	var vDia, vMes, vAno, vNDia, vNMes, vNAno, vNData;
	vValor = obj.value;

	if (vValor.length==0){return;}
	if (vValor.length!=10 && vValor.length>0){vRetorno = false;}
	
	if (vValor.charAt(2) != "/" || vValor.charAt(5) != "/"){
		vRetorno = false;
	}
	vDia = vValor.substr(0,2);
	vMes = vValor.substr(3,2);
	vAno = vValor.substr(6,4);
	vDia = parseInt(vDia, 10);
	vMes = parseInt(vMes, 10);
	vAno = parseInt(vAno, 10);
				
	vNData = new Date(vMes+"/"+vDia+"/"+vAno)
	vNDia = vNData.getDate();
	vNMes = vNData.getMonth()+1;
	vNAno = vNData.getFullYear();
	vNDia = parseInt(vNDia, 10);
	vNMes = parseInt(vNMes, 10);
	vNAno = parseInt(vNAno, 10);				
				
	if ((parseInt(vDia)!=parseInt(vNDia)) || (parseInt(vMes)!=parseInt(vNMes)) || (parseInt(vAno)!=parseInt(vNAno))) {
		vRetorno = false;
	}
				
	if (vRetorno==false){
		alert("Data Invalida.");
		obj.focus();
		obj.select();
	}
	return;
}

///
//Função para retirar caracteres especiais
//Caracteres: !$%*()-+=/\"\f\r\n.,<>:;?[]{}@#_¨
//validação para proteger integridade do banco de dados. 
//ex.: <input type="text" onkeypress="verificarCaracter(event.keyCode);">
//autor: MAURICIO JUNIOR
//64 = @
//46 = .
//95 = _
//45 = -
function verificarCaracter(evento){
	//alert(evento);
	if (evento == 37 || evento == 39 || evento == 38 || evento == 34
		|| evento == 36 || evento == 42 || evento == 40 || evento == 41
		|| evento == 43 || evento == 61 || evento == 47
		|| evento == 92 || evento == 44 || evento == 60
		|| evento == 62 || evento == 58 || evento == 59 || evento == 63
		|| evento == 91 || evento == 93 || evento == 123 || evento == 125
		|| evento == 33 || evento == 124 || evento == 35
		|| evento == 168){
		window.event.keyCode = 0;
	}
}
//onkeypress="return isNumberKey(event)" 
function isNumberKey(evt)
{
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;

    return true;
}

//***************** 
// Codigo para aumentar e diminuir fonte
var tam = 11;

function mudaFonte(tipo,elemento){
	if (tipo=="mais") {
		if(tam<24) tam+=1;
		createCookie('fonte',tam,365);
	} else {
		if(tam>10) tam-=1;
		createCookie('fonte',tam,365);
	}
	var numero_destaques=11;
	var numero_linkmanchete=2;

	var numero_linkfeature = 0;

	document.getElementById('txt_home').style.fontSize = tam+'px';

}

function createCookie(name,value,days) {
	if (days) {
		var date = new Date();
		date.setTime(date.getTime()+(days*24*60*60*1000));
		var expires = "; expires="+date.toGMTString();
	} else var expires = "";
	document.cookie = name+"="+value+expires+"; path=/";
}

function readCookie(name) {
	var nameEQ = name + "=";
	var ca = document.cookie.split(';');
	for(var i=0;i < ca.length;i++)
	{
		var c = ca[i];
		while (c.charAt(0)==' ') c = c.substring(1,c.length);
		if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
	}
	return null;
}

//********* Fim aumentar e diminuir fonte