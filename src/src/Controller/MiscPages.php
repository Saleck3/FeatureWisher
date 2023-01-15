<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class MiscPages extends AbstractController
{
    /**
     * @Route("/", name="app_home")
     * @return Response
     */
    public function homePage()
    {

        $wishes = array(
            array('id' => 1, 'title' => "A database for this system!", 'description' => "How do you make a system without a database dude?", 'upvotes' => 5, 'downvotes' => 1),
            array('id' => 2, 'title' => "Maybe some services?", 'description' => "We will need some APIs or something", 'upvotes' => 15, 'downvotes' => 0)
        );

        return $this->render("home.html.twig", [
            'wishes' => $wishes,
        ]);

    }

}