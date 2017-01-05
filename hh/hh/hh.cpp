#include "hh.h"
#include "hhFrame.h"

IMPLEMENT_APP( MyApp );

bool MyApp::OnInit()
{
	hhFrame* frame = new hhFrame();
	frame->SetIcon( wxICON( amain ) );
	frame->Show();
	return true;
}
