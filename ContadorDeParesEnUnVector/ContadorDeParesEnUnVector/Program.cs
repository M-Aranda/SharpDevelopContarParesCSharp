/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/25/2018
 * Time: 7:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ContadorDeParesEnUnVector
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			// TODO: Implement Functionality Here
			int[] zapatos= {42,40,41,42,36,41,36,36,41,41,41,46,46,47,41};
			//int[] zapatos= {2,2,3,3,2,2,3,3};
			
			String cantidadDePares=GetCount(zapatos).ToString();
			
			Console.WriteLine("La cantidad de pares en este vector es de "+cantidadDePares);
			Console.WriteLine("Pulse cualquier tecla para continuar... ");
			Console.ReadKey(true);
		}
		
		
		
		
		
		
		public static int GetCount(int [] zapatos){
			int cantPares=0;
			String seContaronEstosValores="";

			for (int i = 0; i < zapatos.Length; i++){
				
				int ocurrenciasDeUnNumero=0;		
				
				if(!seContaronEstosValores.Contains(zapatos[i].ToString())){
				for (int j = 0; j < zapatos.Length; j++) {
					if(zapatos[i]==zapatos[j]){
						ocurrenciasDeUnNumero++;
					}
				}
	
				if(ocurrenciasDeUnNumero>1){
					cantPares+=(ocurrenciasDeUnNumero/2);
				}
				
				seContaronEstosValores=seContaronEstosValores+zapatos[i];			
				}	
					}			
			return cantPares;		
		}
		
		



		
		
		
	}
}