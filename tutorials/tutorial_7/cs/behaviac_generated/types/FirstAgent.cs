﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT

///<<< END WRITING YOUR CODE

public class FirstAgent : behaviac.Agent
///<<< BEGIN WRITING YOUR CODE FirstAgent
///<<< END WRITING YOUR CODE
{
	private int p1 = 0;
	public void _set_p1(int value)
	{
		p1 = value;
	}
	public int _get_p1()
	{
		return p1;
	}

	private void Start()
	{
///<<< BEGIN WRITING YOUR CODE Start
        count = 0;
///<<< END WRITING YOUR CODE
	}

	private behaviac.EBTStatus Wait()
	{
///<<< BEGIN WRITING YOUR CODE Wait
        count++;

        Console.WriteLine("p1 = {0}", p1);

        if (count == 10000)
        {
            return behaviac.EBTStatus.BT_SUCCESS;
        }

        return behaviac.EBTStatus.BT_RUNNING;
///<<< END WRITING YOUR CODE
	}

///<<< BEGIN WRITING YOUR CODE CLASS_PART
    private int count;
///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

