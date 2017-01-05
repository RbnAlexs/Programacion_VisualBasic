#include "Project.h"
#include "ProjectFrame.h"

IMPLEMENT_APP( MyApp );

bool MyApp::OnInit()
{
	ProjectFrame* frame = new ProjectFrame();
	frame->SetIcon( wxICON( amain ) );
	frame->Show();
	return true;
}
