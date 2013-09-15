package org.ogman.internals;

public class PublicFacing extends InternalInterface {

	private StringBuffer output;

	public PublicFacing(StringBuffer output) {
		this.output = output;
	}

	public void doWork() {
		output.append("Public work is based on ");
		doInternalWork();
		output.append(".");
	}

	@Override
	void doInternalWork() {
		output.append("internal work");
	}
}
