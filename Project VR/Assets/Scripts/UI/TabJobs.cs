using System.Collections.Generic;
using UnityEngine;

public class TabJobs : Tab
{
    public GameObject jobPrefab;
    public Transform JobsParent;

    List<JobUI> jobsUIs = new List<JobUI>();

    public override void Activate()
    {
        gameObject.SetActive(true);
    }

    public override void Desactivate()
    {
        gameObject.SetActive(false);
    }

    public override void UpdateContent(Piece piece)
    {
        ClearJobs();
        if (piece == null) return;
        for (int i = 0; i < piece.jobs.Length; i += 1)
        {
            AddJob(piece.jobs[i]);
        }
    }

    void ClearJobs()
    {
        for (int i = 0; i < jobsUIs.Count; i += 1)
        {
            Destroy(jobsUIs[i].gameObject);
        }
        jobsUIs.Clear();
    }

    void AddJob(Job job)
    {
        JobUI jobUI = Instantiate<GameObject>(jobPrefab, JobsParent).GetComponent<JobUI>();
        jobsUIs.Add(jobUI);
        jobUI.UpdateContent(job);
    }
}
