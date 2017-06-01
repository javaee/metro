/*
 * The contents of this file are subject to the terms
 * of the Common Development and Distribution License
 * (the License).  You may not use this file except in
 * compliance with the License.
 *
 * You can obtain a copy of the license at
 * https://glassfish.dev.java.net/public/CDDLv1.0.html.
 * See the License for the specific language governing
 * permissions and limitations under the License.
 *
 * When distributing Covered Code, include this CDDL
 * Header Notice in each file and include the License file
 * at https://glassfish.dev.java.net/public/CDDLv1.0.html.
 * If applicable, add the following below the CDDL Header,
 * with the fields enclosed by brackets [] replaced by
 * you own identifying information:
 * "Portions Copyrighted [year] [name of copyright owner]"
 *
 * Copyright 2006 Sun Microsystems Inc. All Rights Reserved
 */

/*
 * The contents of this file are subject to the terms
 * of the Common Development and Distribution License
 * (the "License").  You may not use this file except
 * in compliance with the License.
 *
 * You can obtain a copy of the license at
 * https://jwsdp.dev.java.net/CDDLv1.0.html
 * See the License for the specific language governing
 * permissions and limitations under the License.
 *
 * When distributing Covered Code, include this CDDL
 * HEADER in each file and include the License file at
 * https://jwsdp.dev.java.net/CDDLv1.0.html  If applicable,
 * add the following below this CDDL HEADER, with the
 * fields enclosed by brackets "[]" replaced with your
 * own identifying information: Portions Copyright [yyyy]
 * [name of copyright owner]
 */

using System;

class Client {
	static void Main(String[] args) {
	AddNumbersImplClient port = null;
	try {
	          port = new AddNumbersImplClient("AddNumbersImplPort");
                int number1 = 10;
                int number2 = 20;

		    Console.Write("Adding {0} and {1}.  ", number1, number2);
                int result = port.addNumbers (number1, number2);
                Console.WriteLine("Result is {0}.\n\n",result);
            
                number1 = -10;
		    Console.Write("Adding {0} and {1}.  ", number1, number2);
                result = port.addNumbers (number1, number2);
		    Console.WriteLine("Result is {0}.\n\n",result);
                port.Close();	} catch (System.ServiceModel.FaultException e) 
      {
		Console.WriteLine("Exception: " + e.Message);
		if (port != null) port.Close();
	}
   }
}
