package org.ogman.internals.tests;
import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.assertThat;

import org.junit.Test;
import org.ogman.internals.PublicFacing;

public class PublicFacingTests {

	public class Derived extends PublicFacing {
		public Derived(StringBuffer output) {
			super(output);
		}

		/*this is not allowed at compile time due to low visibility*/
		//@Override
		//void doInternalWork(){
		//	
		//}
	}
	
	@Test
	public void test() {
		StringBuffer output = new StringBuffer();
		PublicFacing inst = new PublicFacing(output);
		inst.doWork();
		/*this is not allowed at compile time due to low visibility*/
		//inst.doInternalWork();
		assertThat(output.toString(),
				is("Public work is based on internal work."));
	}
}
