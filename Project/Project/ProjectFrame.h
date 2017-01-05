#ifndef PROJECTFRAME_H
#define PROJECTFRAME_H

#include "Project_GUI.h"

class ProjectFrame : public MainFrame
{
public:
	ProjectFrame( wxWindow *parent = NULL, int id = -1 );
	~ProjectFrame();
private:
	void OnExit( wxCommandEvent& event );
	void OnAbout( wxCommandEvent& event );
	DECLARE_EVENT_TABLE();
};
#endif // PROJECTFRAME_H
