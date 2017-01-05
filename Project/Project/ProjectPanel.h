#ifndef PROJECTPANEL_H
#define PROJECTPANEL_H

#include "Project_GUI.h"

class ProjectPanel : public MainPanel
{
public:
	ProjectPanel( wxWindow* parent );
	~ProjectPanel();

private:
	void OnOK( wxCommandEvent& event );
	DECLARE_EVENT_TABLE();
};

#endif //PROJECTPANEL_H